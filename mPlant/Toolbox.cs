using System.Windows;
using System.Windows.Controls;

namespace mPlant
{
    public class Toolbox : ItemsControl
    {
        private Size itemSize = new Size(65, 65);
        public Size ItemSize
        {
            get { return this.itemSize; }
            set { this.itemSize = value; }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ToolboxItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return (item is ToolboxItem);
        }
    }
}
