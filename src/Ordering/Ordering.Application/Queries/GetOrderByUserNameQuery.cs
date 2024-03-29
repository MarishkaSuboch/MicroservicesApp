﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Ordering.Application.Responses;

namespace Ordering.Application.Queries
{
    public class GetOrderByUserNameQuery: IRequest<IEnumerable<OrderResponse>>
    {
        public string UserName { get; set; }

        public GetOrderByUserNameQuery(string userName)
        {
            UserName = userName;
        }
    }
}
