using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQuery : IRequest<EventExportFileVm>
    {
    }
}
