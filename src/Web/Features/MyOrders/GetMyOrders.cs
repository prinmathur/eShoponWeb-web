using System.Collections.Generic;
using MediatR;
using Microsoft.eShopWeb.Web.ViewModels;

#new code change added
namespace Microsoft.eShopWeb.Web.Features.MyOrders;

public class GetMyOrders : IRequest<IEnumerable<OrderViewModel>>
{
    public string UserName { get; set; }

    public GetMyOrders(string userName)
    {
        UserName = userName;
    }
}
