using System.Collections.Generic;
using AElf.Kernel.SmartContract.Application;
using AElf.Types;
using Volo.Abp.DependencyInjection;

namespace AElf.Contracts.HealthMinerAsset;

public class NFTContractInitializationProvider : IContractInitializationProvider, ITransientDependency
{
    public Hash SystemSmartContractName { get; } = HashHelper.ComputeFrom("AElf.ContractNames.NFT");
    public string ContractCodeName { get; } = "AElf.Contracts.HealthMinerAsset";

    public List<ContractInitializationMethodCall> GetInitializeMethodList(byte[] contractCode)
    {
        return new List<ContractInitializationMethodCall>();
    }
}