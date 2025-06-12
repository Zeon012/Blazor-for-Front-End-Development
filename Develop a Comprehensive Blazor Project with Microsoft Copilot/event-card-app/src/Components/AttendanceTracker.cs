using System.Collections.Generic;
using System.Linq;

namespace event_card_app.Components
{
    public class AttendanceRecord
    {
        public int EventId { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
    }

    public class AttendanceTracker
    {
        private readonly List<AttendanceRecord> _attendance = new();

        public void RegisterAttendance(int eventId, string name, string email)
        {
            _attendance.Add(new AttendanceRecord { EventId = eventId, Name = name, Email = email });
        }

        public IEnumerable<AttendanceRecord> GetAttendanceForEvent(int eventId)
        {
            return _attendance.Where(a => a.EventId == eventId);
        }
    }
}