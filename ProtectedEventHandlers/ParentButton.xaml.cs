using System.Diagnostics;

namespace ProtectedEventHandlers
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class ParentButton : Button
   {
      public ParentButton()
      {
         InitializeComponent();
      }

      private void ParentButton_OnClicked(object sender, EventArgs e)
      {
         Debug.WriteLine("Parent Button Clicked");
      }
   }
}