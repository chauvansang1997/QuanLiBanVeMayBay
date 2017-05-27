// Copyright © Neil Price 2006
// Free for use
// Just leave this message intact

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Custom
{
    // Return structure for the GetScrollInfo method
    [StructLayout(LayoutKind.Sequential)]
    public struct ScrollInfoStruct
    {
        public int cbSize;
        public int fMask;
        public int nMin;
        public int nMax;
        public int nPage;
        public int nPos;
        public int nTrackPos;
    }
    /// <summary>
    /// Derived ComboBox that shows current position of the cursor inside the drop down
    /// as it's actually moving around in there.  This combobox will raise the custom
    /// event we have defined above whenever a new item is hovered over in the drop down list
    /// </summary>
    public class MyComboBox : ComboBox
    {
        public event EventHandler<ScrollInfo> Scroll;
        // Internal variables to hold the mouse position and the control
        // position for calculating whether the mouse is inside the drop down
        // and whether we scrolled with the mouse inside the drop down
        private int yPos = 0;
        private int xPos = 0;
        private int scrollPos = 0;
        private int xFactor = -1;
        private int simpleOffset = 0;

        // Import the GetScrollInfo function from user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetScrollInfo(IntPtr hWnd, int n, ref ScrollInfoStruct lpScrollInfo);

        // Win32 constants
        private const int SB_VERT = 1;
        private const int SIF_TRACKPOS = 0x10;
        private const int SIF_RANGE = 0x1;
        private const int SIF_POS = 0x4;
        private const int SIF_PAGE = 0x2;
        private const int SIF_ALL = SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS;

        private const int SCROLLBAR_WIDTH = 17;
        private const int LISTBOX_YOFFSET = 21;

        

        public event HoverEventHandler Hover;

        protected virtual void OnHover(HoverEventArgs e)
        {
            HoverEventHandler handler = Hover;
            if (handler != null)
            {
                // Invokes the delegates. 
                handler(this, e);
            }
        }

        //Capture messages coming to our combobox
        protected override void WndProc(ref Message msg)
        {
            //This message code indicates the value in the list is changing
            //32 is for DropDownStyle == Simple
            if ((msg.Msg == 308) || (msg.Msg == 32))
            {
                int onScreenIndex = 0;

                // Get the mouse position relative to this control
                Point LocalMousePosition = this.PointToClient(Cursor.Position);
                xPos = LocalMousePosition.X;

                if (this.DropDownStyle == ComboBoxStyle.Simple)
                {
                    yPos = LocalMousePosition.Y - (this.ItemHeight + 10);
                }
                else
                {   
                    yPos = LocalMousePosition.Y - this.Size.Height - 1;
                }

                // save our y position which we need to ensure the cursor is
                // inside the drop down list for updating purposes
                int oldYPos = yPos;

                // get the 0-based index of where the cursor is on screen
                // as if it were inside the listbox
                while (yPos >= this.ItemHeight)
                {
                    yPos -= this.ItemHeight;
                    onScreenIndex++;
                }

                //if (yPos < 0) { onScreenIndex = -1; }
                ScrollInfoStruct si = new ScrollInfoStruct();
                si.fMask = SIF_ALL;
                si.cbSize = Marshal.SizeOf(si);
                // msg.LParam holds the hWnd to the drop down list that appears
                int getScrollInfoResult = 0;
                getScrollInfoResult = GetScrollInfo(msg.LParam, SB_VERT, ref si);
                
                // k returns 0 on error, so if there is no error add the current
                // track position of the scrollbar to our index
                if (getScrollInfoResult > 0)
                {
                    onScreenIndex += si.nTrackPos;
                    
                    if (this.DropDownStyle == ComboBoxStyle.Simple)
                    {
                        simpleOffset = si.nTrackPos;
                    }
                    if (Scroll != null)
                    {
                        Scroll(this, new ScrollInfo(si));
                    }
                }

                // Add our offset modifier if we're a simple combobox since we don't
                // continuously receive scrollbar information in this mode.
                // Then make sure the item we're previewing is actually on screen.
                if (this.DropDownStyle == ComboBoxStyle.Simple)
                {
                    onScreenIndex += simpleOffset;
                    if (onScreenIndex > ((this.DropDownHeight / this.ItemHeight) + simpleOffset))
                    {
                        onScreenIndex = ((this.DropDownHeight / this.ItemHeight) + simpleOffset - 1);
                    }
                }

                // Check we're actually inside the drop down window that appears and 
                // not just over its scrollbar before we actually try to update anything
                // then if we are raise the Hover event for this comboBox
                if (!(xPos > this.Width - SCROLLBAR_WIDTH || xPos < 1 || oldYPos < 0 || ((oldYPos > this.ItemHeight * this.MaxDropDownItems) && this.DropDownStyle != ComboBoxStyle.Simple)))
                {
                    HoverEventArgs e = new HoverEventArgs();
                    e.itemIndex = (onScreenIndex > this.Items.Count - 1) ? this.Items.Count - 1 : onScreenIndex;
                    OnHover(e);
                    // if scrollPos doesn't equal the nPos from our ScrollInfoStruct then
                    // the mousewheel was most likely used to scroll the drop down list
                    // while the mouse was inside it - this means we have to manually
                    // tell the drop down to repaint itself to update where it is hovering
                    // still posible to "outscroll" this method but it works better than
                    // without it present
                    if (scrollPos != si.nPos)
                    {
                        Cursor.Position = new Point(Cursor.Position.X + xFactor, Cursor.Position.Y);
                        xFactor = -xFactor;
                    }
                }
                scrollPos = si.nPos;
            }
            // Pass on our message
            base.WndProc(ref msg);
        }
    }

    /// <summary>
    /// Class that contains data for the hover event 
    /// </summary>
    public class HoverEventArgs : EventArgs
    {
        private int _itemIndex = 0;
        public int itemIndex
        {
            get
            {
                return _itemIndex;
            }
            set
            {
                _itemIndex = value;
            }
        }
    }

    public class ScrollInfo : EventArgs
    {

        private ScrollInfoStruct info;
        public ScrollInfo(ScrollInfoStruct _info)
        {

            Info = _info;
        }

        public ScrollInfoStruct Info
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }
    }
    /// <summary>
    /// Delegate declaration 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void HoverEventHandler(object sender, HoverEventArgs e);
    

}
