﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocioBoard.Domain
{
    interface IBlog_PostsRepository
    {
        ICollection<Blog_Posts> GetAllBlogPosts(Blog_Posts blog_Posts);
        int Insert(Blog_Posts blog_Posts);
        int Update(Blog_Posts blog_Posts);
        int Delete(Blog_Posts blog_Posts);
    }
}
