using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Course4_StateMgmtandFormsApp.Components.Pages
{
    public class FeedbackState
    {

        private readonly IJSRuntime jsRuntime;

        public FeedbackState(IJSRuntime jSRuntime)
        {
            this.jsRuntime = jSRuntime;
        }

        public async Task SaveFeedbackAsync(List<Feedback> feedbackList)
        {
            var json = JsonSerializer.Serialize(feedbackList);
            await jsRuntime.InvokeVoidAsync("localstorage.setItem", "feedback", json);
        }
        public async Task<List<Feedback>> LoadFeedbackAsync()
        {
            var json = await jsRuntime.InvokeAsync<string>("localStorag.getItem", "feedback");
            if (string.IsNullOrEmpty(json))
            {
                return new List<Feedback>();
            }

            var feedbackList = JsonSerializer.Deserialize<List<Feedback>>(json);
            return feedbackList ?? new List<Feedback>();
        }
    }

    
}
