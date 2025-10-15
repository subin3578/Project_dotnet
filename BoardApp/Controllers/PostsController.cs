using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoardApp.Data;
using BoardApp.Models;

namespace BoardApp.Controllers;

public class PostsController : Controller
{
    private readonly AppDbContext _context;
    public PostsController(AppDbContext context)
    {
        _context = context;
    }

    // 목록 보기
    public async Task<IActionResult> Index(string? q)
    {
        var query = _context.Posts.AsQueryable();
        if (!string.IsNullOrWhiteSpace(q))
            query = query.Where(p => EF.Functions.Like(p.Title, $"%{q}%"));
        var posts = await query.OrderByDescending(p => p.Id).ToListAsync();
        return View(posts);
    }

    // 상세 보기
    public async Task<IActionResult> Details(int id)
    {
        var post = await _context.Posts.FindAsync(id);
        return post == null ? NotFound() : View(post);
    }

    // 글 작성 폼
    public IActionResult Create() => View();

    // 글 작성 처리
    [HttpPost]
    public async Task<IActionResult> Create(Post post)
    {
        if (!ModelState.IsValid) return View(post);
        _context.Add(post);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    // 수정 폼
    public async Task<IActionResult> Edit(int id)
    {
        var post = await _context.Posts.FindAsync(id);
        return post == null ? NotFound() : View(post);
    }

    // 수정 처리
    [HttpPost]
    public async Task<IActionResult> Edit(int id, Post post)
    {
        if (id != post.Id) return BadRequest();
        if (!ModelState.IsValid) return View(post);
        _context.Update(post);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    // 삭제 처리
    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        var post = await _context.Posts.FindAsync(id);
        if (post == null) return NotFound();
        _context.Posts.Remove(post);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}