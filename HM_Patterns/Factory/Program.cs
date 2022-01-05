using Factory;

IDietBase Diet1 = DietFactory.Give_Diat_Now(50,190,1.72);
IDietBase Diet2 = DietFactory.Give_Diat_Now(38, 69, 1.72);
IDietBase Diet3 = DietFactory.Give_Diat_Now(41, 100, 1.72);
IDietBase Diet4 = DietFactory.Give_Diat_Now(20, 100, 1.72);

Diet1.GetDiat();
Diet2.GetDiat();
Diet3.GetDiat();
Diet4.GetDiat();