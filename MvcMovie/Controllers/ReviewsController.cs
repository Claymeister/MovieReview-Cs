using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly MvcMovieContext _context;
        private readonly ILogger<ReviewsController> _logger;

        public ReviewsController(MvcMovieContext context, ILogger<ReviewsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            var reviews = await _context.Review
                .Include(r => r.Movie)
                .Include(r => r.User)
                .OrderByDescending(r => r.CreationTime)
                .ToListAsync();

            return View(reviews);
        }


        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Movie)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        [Authorize(Roles = "Member")]
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.Movie, "Id", "Title");
            ViewData["CreationTime"] = DateTime.Now;
            ViewData["UserId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation("Create wit no args :O");
            return View();
        }

        // POST: Reviews/Create
        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Score,Description,MovieId,UserId,CreationTime")] Review review)
        {
            ModelState.Remove("Movie");
            ModelState.Remove("User");
            if (ModelState.IsValid)
            {
                _logger.LogInformation("ModelState.IsValid triggered");
                
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                _logger.LogInformation("ModelState is not valid. Errors:");
                foreach (var modelStateEntry in ModelState.Values)
                {
                    foreach (var error in modelStateEntry.Errors)
                    {
                        _logger.LogInformation($"Error: {error.ErrorMessage}");
                    }
                }
            }
            _logger.LogInformation("ModelState.IsValid skipped");
            ViewData["MovieId"] = new SelectList(_context.Movie, "Id", "Title", review.MovieId);
            return View(review);
        }


        // GET: Reviews/Edit/5
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            // Check if the current user is authorized to edit the review
            if (review.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return Forbid(); // Return 403 Forbidden if user is not authorized
            }

            // Set ViewData for MovieId to ensure it's displayed in the view
            ViewData["CreationTime"] = DateTime.Now;
            ViewData["UserId"] = review.UserId;

            var movieTitle = await _context.Movie
                .Where(m => m.Id == review.MovieId)
                .Select(m => m.Title)
                .FirstOrDefaultAsync();
            if (movieTitle != null)
            {
                ViewData["MovieTitle"] = movieTitle;
            }

            return View(review);
        }

        // POST: Reviews/Edit/5
        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Score,Description,UserId,CreationTime")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }
            ModelState.Remove("Movie");
            ModelState.Remove("User");
            if (ModelState.IsValid)
            {
                try
                {
                    // Retrieve the existing review from the database
                    var existingReview = await _context.Review.FindAsync(id);

                    // Update only the Score, Description and CreationTime fields
                    existingReview.Score = review.Score;
                    existingReview.Description = review.Description;
                    existingReview.CreationTime = review.CreationTime;

                    // Update the review in the database
                    _context.Update(existingReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                _logger.LogInformation("ModelState is not valid. Errors:");
                foreach (var modelStateEntry in ModelState.Values)
                {
                    foreach (var error in modelStateEntry.Errors)
                    {
                        _logger.LogInformation($"Error: {error.ErrorMessage}");
                    }
                }
            }

            // If ModelState is not valid, set ViewData for MovieId and return the view
            // ViewData["MovieId"] = new SelectList(_context.Movie, "Id", "Title", review.MovieId);
            return View(review);
        }


        // GET: Reviews/Delete/5
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Movie)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }
            // Check if the current user is authorized to edit the review
            if (review.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier)
                && !User.IsInRole("Admin"))
            {
                return Forbid(); // Return 403 Forbidden if user is not authorized
            }

            return View(review);
        }

        // POST: Reviews/Delete/5
        [Authorize(Roles = "Member")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Review.FindAsync(id);
            if (review != null)
            {
                _context.Review.Remove(review);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Review.Any(e => e.Id == id);
        }
    }
}