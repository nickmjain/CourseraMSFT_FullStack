namespace Course4_EventEase.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        // Add other relevant fields (e.g., phone number, event ID)
        [Required(ErrorMessage = "Event ID is required.")]
        public int EventId { get; set; }
    }

}
