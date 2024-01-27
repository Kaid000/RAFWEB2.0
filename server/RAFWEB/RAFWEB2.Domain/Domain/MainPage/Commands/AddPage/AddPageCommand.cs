using MediatR;
using RAFWEB2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAFWEB2.Domain.Domain.MainPage.Commands.AddPage
{
    public record AddPageCommand(MainPageContent MainPageContent) : IRequest<MainPageContent>
    {
    }
}
