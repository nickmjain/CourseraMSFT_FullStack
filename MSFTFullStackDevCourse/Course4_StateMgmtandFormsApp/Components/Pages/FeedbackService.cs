namespace Course4_StateMgmtandFormsApp.Components.Pages
{
    public class FeedbackService
    {
            private List<Feedback> feedbackList;

            public void AddFeedback(Feedback feedback)
            {
                if (feedbackList == null)
                {
                    feedbackList = new List<Feedback>();
                }
                feedbackList.Add(feedback);
            }

            public IEnumerable<Feedback> GetFeedback() => feedbackList;
    }
}
