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

  public int GetPendingInviteCount(List<MeetingAttendee> allAttendees , int targetUserId)
  {
    int count = allAttendees.Where(a => a.UserId == targetUserId && a.RSVPStatus==Statusu.Pending).Count();

    return count ; 
  }
}