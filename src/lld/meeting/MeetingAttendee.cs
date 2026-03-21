using System.Data.Common;
using System.Net;
public enum Statusu
  {
    Accepted , 
    Declined , 
    Tentative,
    Pending ,
  }

public class MeetingAttendee
{
  public int Id {get ; set ;} 
  public int UserId {get ; set ; }

  public int MeetingId {get ; set ; }

  public Statusu RSVPStatus {get ; set ; }
}