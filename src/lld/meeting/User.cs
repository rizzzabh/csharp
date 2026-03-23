public class User
{
  public int Id {get ; set ; }
  public int Name {get ; set ; }

  public int Password {get ; set ;}

  public int EmailId {get ; set ;}
  public ICollection<MeetingAttendee> MeetingAttendees {get ; set ; } = new List<MeetingAttendee>() ; 

}


