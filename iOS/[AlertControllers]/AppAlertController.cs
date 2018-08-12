using System;
using UIKit;

namespace Lasallistas.iOS.AlertControllers
{
    public class AppAlertController
    {

        public enum ActionStyle
        {
            Default,
            Accent
        }
        public AppAlertController()
        {
        }

        public void AddAction(string title, ActionStyle style, EventHandler handler)
        {
            var button = new UIButton(UIButtonType.Custom)
            {
                BackgroundColor = style == ActionStyle.Accent ? new UIColor(0xCF / 255f, 0x08 / 255f, 0x20 / 255f, 1) : new UIColor(0x22 / 255f, 0x33 / 255f, 0x44 / 255f, 1)
            };
            button.SetTitle(title, UIControlState.Normal);
            button.TouchUpInside += (sender, e) =>
            {
                handler?.Invoke(sender, e);
                DismissViewController(true, null);
            };
            actionStack.AddArrangedSubview(button);
        }

        public static AppAlertController Create(string title, string message)
        {
            var controller = UIStoryboard.FromName("Main", null).InstantiateViewController("AppAlertController") as AppAlertController;
            var _ = controller.View;    // Call it's view to preload outlets.
            controller.titleLabel.Text = title;
            controller.messageLabel.Text = message;
            foreach (UIView view in controller.actionStack.Subviews)
            {
                controller.actionStack.RemoveArrangedSubview(view);
                view.RemoveFromSuperview();
            }
            controller.View.BackgroundColor = new UIColor(0, 0.4f);
            controller.ModalPresentationStyle = UIModalPresentationStyle.OverFullScreen;
            controller.ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve;
            return controller;
        }
    }
}
