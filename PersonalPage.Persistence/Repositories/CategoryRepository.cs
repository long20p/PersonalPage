using PersonalPage.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPage.Persistence.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbContext context) : base(context)
        {
        }

        protected override string CollectionName => "categories";
    }
}
