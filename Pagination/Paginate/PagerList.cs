using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.Paginate
{
    public class PagerList<T> : List<T>
    {
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }

        public PagerList(List<T> items, int count, int pageIndex, int pageSize)
            {
            CurrentPage = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
            }

        public bool ShowPrevious => CurrentPage > 1;

        public bool ShowNext => CurrentPage < TotalPages;

        public bool ShowFirst => CurrentPage != 1;

        public bool ShowLast => CurrentPage != TotalPages;

        public static async Task<PagerList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PagerList<T>(items, count, pageIndex, pageSize);
        }
    }
}
