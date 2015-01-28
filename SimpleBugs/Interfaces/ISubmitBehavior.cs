using SimpleBugs.Models;

namespace SimpleBugs.Interfaces {
    public interface ISubmitBehavior {
        void Submit();
        IStatus Status { get; set; }
        IPriority Priority { get; set; }
        BugTicket Ticket { get; set; }
    }
}
