using HomeApplianceRepair.Interfaces;

namespace HomeApplianceRepair.Models
{
    public abstract class Appliance : IRepairable  //صف مجرد أساسي
    {
        private readonly string _serialNumber; // الرقم التسلسلي غير قابل للتعديل
        private string _brand;  // العلامة التجارية
        private string _status;  // حالة الصيانة

        public string SerialNumber
        {
            get { return _serialNumber; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Status
        {
            get { return _status; }
            protected set { _status = value; }
        }

        protected Appliance(string serialNumber, string brand)     // دالة التشييد لتهيئة كائن الجهاز بالحالة الابتدائية

        {
            _serialNumber = serialNumber;
            _brand = brand;
            _status = "Waiting for Maintenance"; // الحالة الابتدائية
        }

        public void StartMaintenance()
        {
            Status = "Under Maintenance";
        }

        public void CompleteRepair()
        {
            Status = "Repaired";
        }

        public string GetStatus()
        {
            return Status;
        }

        public abstract decimal CalculateRepairCost();        // الدالة المجردة لحساب التكلفة التي ستطبّقها الفئات الفرعية

    }
}
