﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feactures.Events.Queries.GetEventsList
{
    public class GetEventsListQuery:IRequest<List<EventListVm>>
    {

    }
}
