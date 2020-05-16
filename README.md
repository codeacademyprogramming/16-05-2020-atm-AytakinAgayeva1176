# 16.05.2020-atm


ATM (bankomat) program:

1. Card adinda bir class yaradirsiniz hansi ki, asagidaki fieldleri* var:
   
   - PAN (kartin uzerindeki 16 reqemli kod) /string
   - PIN (siniz karti bankamata daxil ederken yazdiginiz 4 reqemli kod) /string
   - CVC (kartin arxasindaki 3 reqemli kod) /string
   - Expire Date (month/year (kartin etibarlilib muddeti meselen(06/22))) /string
   - Balans /decimal

2. User adinda bir class yaradirsiniz hansi ki, asagidaki fieldleri var:
 
   - Name /string
   - Surname /string
   - CreditCard /Card

3. User massiv yaradirsiniz ve ora evvelceden 5 user yaradib elave edirsiniz. Kart melumatlarini ozunuz  elave edirsiniz.

4. Proqram ise dusen kimi sizden PIN daxil etmeyinizi teleb edecek. Eger daxil etdiyiniz PIN e uygun kart varsa  yazilacaq ki, "{Name} {Surname} xos gelmisiniz zehmet olmasa asagidakilardan birini secerdiniz". 

    1. Balans
    2. Nagd pul

     2.1. 1 secilen zaman kartdaki balansi gostermelidir
     2.2. 2 seclien zaman:

        1. 10 AZN
        2. 20 AZN
        3. 50 AZN
        4. 100 AZN
        5. Diger (Istediyi meblegi ozu qeyd ede biler)
     
     2.3. Nezere alin ki, cixarmaq istediyiniz pul eger kartdaki balansdan coxdursa.Exception atmalidir ki "Balansda yeterli qeder mebleg yoxdur". 
     2.4 Eger yerli qeder mebleg varsa balansdan secilen qeder mebleg cixilmali ve proqram yeniden menyuya qayitmalidir. Men artiq bu sefer Balans secende artiq Balansdaki pulun azaldigini gormeliyem.

   Eger daxil etdiyiniz PIN yoxdursa o zaman "bu PIN koda aid kart tapilmadi" yazilmalidir. Ve yeniden basa qayitmali ve sizden PIN kod daxil etmeyinizi istemelidir.


Ugurlar... 
 
   	
