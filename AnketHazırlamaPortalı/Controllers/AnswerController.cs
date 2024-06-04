using AnketHazırlamaPortalı.API.Dtos;
using AnketHazırlamaPortalı.API.Models;
using AnketHazırlamaPortalı.Dtos;
using AnketHazırlamaPortalı.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class AnswersController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public AnswersController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/Answers
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AnswerDto>>> GetAnswers()
    {
        var answers = _context.Answers.ToList();
        var answersDtos = _mapper.Map<List<AnswerDto>>(answers);
        return answersDtos;
    }

    // GET: api/Answers/5
    [HttpGet("{id}")]
    public async Task<ActionResult<AnswerDto>> GetAnswer(int id)
    {
        var answer = await _context.Answers.FindAsync(id);
        if (answer == null)
        {
            return NotFound();
        }
        return _mapper.Map<AnswerDto>(answer);
    }

    // POST: api/Answers
    [HttpPost]
    public async Task<ActionResult<AnswerDto>> PostAnswer(AnswerDto answerDTO)
    {
        if (answerDTO == null)
        {
            return BadRequest("Answer DTO is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var answer = _mapper.Map<Answer>(answerDTO);
        _context.Answers.Add(answer);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAnswer), new { id = answer.Id }, _mapper.Map<AnswerDto>(answer));
    }

    // PUT: api/Answers/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAnswer(int id, AnswerDto answerDTO)
    {
        if (answerDTO == null)
        {
            return BadRequest("Answer DTO is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var answer = await _context.Answers.FindAsync(id);
        if (answer == null)
        {
            return NotFound();
        }

        _mapper.Map(answerDTO, answer);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/Answers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnswer(int id)
    {
        var answer = await _context.Answers.FindAsync(id);
        if (answer == null)
        {
            return NotFound();
        }
        _context.Answers.Remove(answer);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}