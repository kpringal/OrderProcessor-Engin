namespace Order.ProcessingEngin.Common
{
    public enum OrderEnum
    {
        PhysicalProduct,
        Book,
        MemberShip,
        UpgradeMemberShip,
        LearningToSki,
    }

    public enum RuleCommandEnum
    {
        GeneratePackingSlip,
        GenerateDuplicatePackingSlip,
        ActivateMembership,
        UpgradeMembership,
        SendMail,
        AddFirsAidVideo,
        GenerateCommisionPayment
    }
}
