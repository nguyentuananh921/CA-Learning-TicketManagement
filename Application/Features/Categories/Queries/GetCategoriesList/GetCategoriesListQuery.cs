﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
