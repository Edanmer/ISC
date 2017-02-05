	interface PhoneInterface
    {
        void Call();
    }

    interface PlugInterface
    {
        void Charge();
    }

    interface CamaraInterface
    {
        void TakeAPhoto();
    }

    class Camara10MP : CamaraInterface
    {
        double Megapixels= 10.0;

        void CamaraInterface.TakeAPhoto()
        {
            // Take A Photo Logic
        }
    }

    class Camara5MP : CamaraInterface
    {
        double Megapixels = 5.0;

        void CamaraInterface.TakeAPhoto()
        {
            // Take A Photo Logic
        }
    }

    class USAPlug : PlugInterface
    {
        string PlugType = "USA";

        void PlugInterface.Charge()
        {
            // Charge Logic
        }
    }

    class EUPlug : PlugInterface
    {
        string PlugType = "EU";

        void PlugInterface.Charge()
        {
            // Charge Logic
        }
    }

    class Samsung : PhoneInterface
    {
        string OS = "Android";

        void PhoneInterface.Call()
        {
            // Call Logic
        }

    }
    class Iphone : PhoneInterface
    {
        string OS = "iOS";

        void PhoneInterface.Call()
        {
            // Call Logic
        }
    }

    class PhoneBuilder
    {
        PhoneInterface Phone;
        CamaraInterface Camara;
        PlugInterface Plug;

        // Constructor
        public PhoneBuilder(PhoneInterface PhoneI, PlugInterface PlugI, CamaraInterface CamaraI)
        {
            this.Phone = PhoneI;
            this.Camara = CamaraI;
            this.Plug = PlugI;
        }
    }