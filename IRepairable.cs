//تحديد العمليات التي يجب ان يعمها الجهاز //
namespace HomeApplianceRepair.Interfaces
{
    public interface IRepairable
    {
        // Start maintenance
        void StartMaintenance();  //بدء صيانة الجهاز//

        // Mark the repair as complete
        void CompleteRepair(); //تسجيل اكتمال الاصلاح//

        // Return the current appliance status
        string GetStatus(); //ارجاع حالة الجهاز الحالية //
    }
}
