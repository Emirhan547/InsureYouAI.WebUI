using InsureYouAI.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.ArticleDtos;

public record CreateArticleDto( string Title, string Content, string CoverImageUrl, string MainCoverImageUrl, DateTime CreatedDate, int CategoryId);
