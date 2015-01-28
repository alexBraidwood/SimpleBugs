using SimpleBugs.Interfaces;
using SimpleBugs.Models;

namespace SimpleBugs {
    public class BaseSubmitBehavior : ISubmitBehavior {

        public BaseSubmitBehavior(BugTicket ticket, IPriority priority, IStatus status) {
            Status = status;
            Priority = priority;
            Ticket = ticket;
        }
        
        public void Submit() {
            
        }

        public IStatus Status { get; set; }
        public IPriority Priority { get; set; }
        public BugTicket Ticket { get; set; }
    }
}
