using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.Business.Dtos.ArticleDtos;

    public record ResultArticleDto(int Id, string Title, string Content, string CoverImageUrl, string MainCoverImageUrl, DateTime CreatedDate, int CategoryId);
