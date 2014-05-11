Vizuelno_programiranje_proekt
=============================
&emsp;Целта на оваа апликација е  да понудиме на корисникот можност за релаксација заедно со неговите омилени песни. Нашиот тим  реши да направи апликација за пуштање на музика. Глобално за креирање на апликацијата беше искористена идејата на Winamp.<br><br>
&emsp;Исцртувањето на хармониците и баровите во горниот, десен агол кога одредена песна е активна се прави со генерирање на рандом броеви и исцртување на линиите според нив. Има основна апстрактна класа, од која наследуваат двата погледи кои се достапни. Со клик на копчето Change View може да се промени поглед. Исто така, за симулирање на вредностите на equalizer - от при негова промена се користи класа која наследува од истата апстрактна класа како и двата погледи.<br><br>
&emsp;<a href="http://imgur.com/2GTydjl"><img src="http://i.imgur.com/2GTydjl.png" title="Hosted by imgur.com" /></a>
&emsp;<a href="http://imgur.com/8dTlmLl"><img src="http://i.imgur.com/8dTlmLl.png" title="Hosted by imgur.com" /></a>
&emsp;<a href="http://imgur.com/g16gaIs"><img src="http://i.imgur.com/g16gaIs.png" title="Hosted by imgur.com" /></a><br><br>
&emsp;Со движење на Trackbar – овите (слајдерите) се прави промена во фрекфенцијата на звукот	 со што придонесува некои форми да бидат подоминантни. Со промена на нивната вредност се прави исцртување на крива линија која визуелно ни ја претставува состојбата во која се наоѓаат слајдерите. Секоја вредност на слајдерот претставува y – координата на точка во делот каде што се исцртува. Вкупно се 10 слајдери од кои се прави листа од 10 точки која служи за исцртување на кривата.<br><br>
&emsp;<a href="http://imgur.com/Lro49FD"><img src="http://i.imgur.com/Lro49FD.png" title="Hosted by imgur.com" /></a>
&emsp;<a href="http://imgur.com/HPksyii"><img src="http://i.imgur.com/HPksyii.png" title="Hosted by imgur.com" /></a><br><br>
&emsp;Над делот во кој се исцртува кривата се прикажува времето на тековната песна. Тоа е овозможено со Timer кој што одбројува на секоја секунда и ја зголемува променливата во која се чуваат секундите, преку кое се добиваат во која минута и секунда е песната и притоа се прикажуваат во соодветниот Теxt box. Progress bar – от се користи за визулено да се претстави колку од вкупната должина на песната е помината и неговата вредност константно се зголемува за еден се до крајот на песната.<br><br>
&emsp;<a href="http://imgur.com/h65ZW82"><img src="http://i.imgur.com/h65ZW82.png" title="Hosted by imgur.com" /></a>
&emsp;<a href="http://imgur.com/rBOB9C9"><img src="http://i.imgur.com/rBOB9C9.png" title="Hosted by imgur.com" /></a><br><br>
&emsp;За да се овозможи регулирање на висината на тонот додаден е уште еден слајдер со хоризонтална поставеност.<br>
&emsp;<a href="http://imgur.com/GkLHQ30"><img src="http://i.imgur.com/GkLHQ30.png" title="Hosted by imgur.com" /></a><br><br>
&emsp;Името на тековната песна се прикажува во подвижна лабела која се придвижува од лево на десно. Тоа е овозможено преку Timer – от кој ја зголемува позицијата на горната лева точка на лабелата во однос на Х – оската на кратки временски интервали што за нас изледа како да се движи.<br><br>
&emsp;<a href="http://imgur.com/ObxCU0D"><img src="http://i.imgur.com/ObxCU0D.png" title="Hosted by imgur.com" /></a><br><br>
&emsp;Копчињата ги нудат основните функционалности како и во секој друг player. Сите заедно наследуваат од апстрактната класа ButtonShape која пак наследува од класата Button. На секое копче се додава различна слика која се менува на Hover за подобар ефект во моментот кога покажувачот се наоѓа над соодветното копче. Кога покажувачот ќе се тргне од површината на копчето, сликата се менува во претходно поставената.<br>
&emsp;<a href="http://imgur.com/woFbyVe"><img src="http://i.imgur.com/woFbyVe.png" title="Hosted by imgur.com" /></a>
&emsp;Play - При клик на ова копче, се стартува песната која е моментално селектирана во листата на песни. Исто така одредена песна може да се стартува и со двоен клик на неа, а исто нејзино селектирање и стискање на enter. Откако ќе отсвири крајната песна во листата, кружно започнува со свирење првата песна.<br><br>
&emsp;<a href="http://imgur.com/s7oCqzb"><img src="http://i.imgur.com/s7oCqzb.png" title="Hosted by imgur.com" /></a>
&emsp;Pause - Моменталната песна ја паузира. Со повторен клик на ова копче, песната продолжува од каде што застанала.<br><br> 
&emsp;<a href="http://imgur.com/StwUp7k"><img src="http://i.imgur.com/StwUp7k.png" title="Hosted by imgur.com" /></a>
&emsp;Stop - Кликнувањето на ова копче ја стопира тековната песна, и како следна ја активира првата песна од листата.<br><br>
&emsp;<a href="http://imgur.com/vCc885u"><img src="http://i.imgur.com/vCc885u.png" title="Hosted by imgur.com" /></a>
&emsp;Shuffle - Со кликнувањето на ова копче се овозможува следната песна која ќе се пушти да не биде веднаш после тековната во листата, туку да може со еднаква веројатност да се појави било која од листата. Со повторен клик на ова копче се исклучува случајниот пристап до песните и моменталната не се запира, а текот на песни ќе продолжи секвенцијално од неа.<br><br>
&emsp;<a href="http://imgur.com/7suD6SA"><img src="http://i.imgur.com/7suD6SA.png" title="Hosted by imgur.com" /></a>
&emsp;Forward - Оди на наредната песна од листата запирајќи ја моменталната која свири. Ако претходно сме кликнале на shuffle, тогаш ќе скокне на случајна песна од листата.<br><br>
&emsp;<a href="http://imgur.com/m5ZnKbG"><img src="http://i.imgur.com/m5ZnKbG.png" title="Hosted by imgur.com" /></a>
&emsp;Rewind - Аналогно на forward, но ги врти песните во обратен редослед. <br><br>
&emsp;<a href="http://imgur.com/bSbe4b8"><img src="http://i.imgur.com/bSbe4b8.png" title="Hosted by imgur.com" /></a>
&emsp;Add song - Со клик на ова копче се отвора дијалог прозорец за одбирање на песна од диск. Може да се изберат и повеќе песни одеднаш. Откако ќе се изврши селекција, песните се додаваат во листата со песни. Исто така, додавањето на песни може да се изврши и со drag and drop.<br><br>
&emsp;<a href="http://imgur.com/AEBvPIS"><img src="http://i.imgur.com/AEBvPIS.png" title="Hosted by imgur.com" /></a>
&emsp;Remove - Селектираната песна се брише од листата. Меѓутоа таа не се запира и продолжува да свири. Може исто така и да се паузира иако е избришана од листата. Бришењето на песна може исто така да се направи и со селектирање на неа и со стискање на копчето delete од тастатура. <br><br>
&emsp;<a href="http://imgur.com/9eIdFHb"><img src="http://i.imgur.com/9eIdFHb.png" title="Hosted by imgur.com" /></a>
&emsp;Remove all - Ги брише сите песни од листата.<br><br>
&emsp;<a href="http://imgur.com/r6uRonA"><img src="http://i.imgur.com/r6uRonA.png" title="Hosted by imgur.com" /></a>
&emsp;Отвора нов диалог прозорец за избор на боја. По изборот и кликнување на копчето OK настанува промена на позадинската боја на апликацијата.<br><br>
&emsp;<a href="http://imgur.com/WclUzXb"><img src="http://i.imgur.com/WclUzXb.png" title="Hosted by imgur.com" /></a><br><br>
&emsp;<b>Опис на методот PlaySong(Song song)</b><br>
&emsp;ISoundOut е интерфејс чиј изворен код го првземавме од http://cscore.codeplex.com/. Исто така и Equalizer е класа која работи со подесување на звукот со помош на баровите во средината на player-от, и е превземена од истото место. PlaySong(Song song) е најкористениот метод во нашата апликација, и се повикува при клик на различни копчиња. Тој ги иницијализира _soundOut и _eq. Потоа со помош на _soundOut може да се регулира пуштањето на песна, паузирањето, стопирањето итн. Со _eq се регулира equalizer - от. По иницијализацијата на овие клучни променливи, се пуштаат двата тајмери за исцртување на хармониците и за следење на текот на песната, соодветно.<br><br>
&emsp;За крај овозможивме и серијализација на песните кои моментално се додадени во листата, за да нема потреба при секое вклучување на апликацијата повторно да се додаваат веќе претходно додадени песни. Кoнечниот изглед на апликацијата е следниов: <br><br>
&nbsp;<a href="http://imgur.com/a8pzzQ7"><img src="http://i.imgur.com/a8pzzQ7.png" title="Hosted by imgur.com" /></a>




<br><br><b>Изработиле:</b><br>
&emsp;Кирил Пеповски 121102<br>
&emsp;Гроздан Маџаров 121107<br>
&emsp;Ивица Обадиќ 121144<br>

