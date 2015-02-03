namespace SimpleBugs.Interfaces
{
    using  SimpleBugs.Models;

    public interface ISubmitBehavior
    {
        void Submit();
        IStatus Status { get; set; }
        IPriority Priority { get; set; }
        BugTicket Ticket { get; set; }
    }
}
