using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommand : IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}
