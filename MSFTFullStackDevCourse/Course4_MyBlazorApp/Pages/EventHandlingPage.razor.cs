using Microsoft.AspNetCore.Components;

namespace Course4_MyBlazorApp.Pages
{
    public partial class EventHandlingPage : ComponentBase
    {
        private int cartCount = 0;
        private string searchQuery = "";
        private string productDetails = "";

        private void AddToCart()
        {
            cartCount++; // Increases cart count
        }

        private void UpdateSearch(ChangeEventArgs e)
        {
            searchQuery = e.Value.ToString(); // Updates search query
            StateHasChanged(); // Updates the UI
        }

        private void ShowProductDetails()
        {
            productDetails = "Eco-friendly product with reusable packaging."; // Updates details on hover.
            StateHasChanged(); // Updates the UI
        }
    }

}
