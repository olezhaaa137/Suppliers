﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suppliers.Application.Contracts.Queries.GetContractsList
{
    public class GetContractsListQuery : IRequest<ContractListVm>
    {
    }
}
