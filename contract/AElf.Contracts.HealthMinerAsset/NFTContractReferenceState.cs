using AElf.Contracts.MultiToken;
using AElf.Contracts.Parliament;
using AElf.Standards.ACS6;

namespace AElf.Contracts.HealthMinerAsset;

public partial class NFTContractState
{
    internal TokenContractContainer.TokenContractReferenceState TokenContract { get; set; }

    internal RandomNumberProviderContractContainer.RandomNumberProviderContractReferenceState
        RandomNumberProviderContract { get; set; }

    internal ParliamentContractContainer.ParliamentContractReferenceState ParliamentContract { get; set; }
}