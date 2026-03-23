[Route("api/[controller]")]
[ApiController]
public class MeetingsController : ControllerBase
{
    private readonly IMeetingRepository _repository;

    public MeetingsController(IMeetingRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllMeetings()
    {
        var meetings = _repository.GetAll();
        return Ok(meetings); 
    }

    [HttpGet("{id}")]
    public IActionResult GetMeetingById(int id)
    {
        var meeting = _repository.GetById(id);
        if (meeting == null) return NotFound(); 
        
        return Ok(meeting);
    }

    [HttpPost]
    public IActionResult CreateMeeting([FromBody] MeetingSummaryDto newMeeting)
    {
        _repository.Save(newMeeting);
        return Created(); 
    }
}