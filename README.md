# RockPaperScissors

## Цели
- Да се създаде интерактивна игра „Камък, Ножица, Хартия“, която позволява на потребителя да играе срещу компютър.
- Да се осигури визуална обратна връзка за резултатите от играта.
##  Предназначение
Проектът е предназначен за развлекателни цели, като позволява на потребителите да се забавляват, играейки тази класическа игра.
## Структура
### Форма за Вход (Login Form)
Позволява на потребителя да въведе своето име и да стартира играта. Съдържа PictueBox, изобразяващ логото ни, текстово поле за въвеждане на име и бутон „Start“.

![](https://lh7-us.googleusercontent.com/docsz/AD_4nXfeaxJkFKX849zgVN7lxg9SPSYPVbd9iSCmPHOaTLVY8uKbmpt4648tCjfWZlM3yuT0WjguC7l3e2hPQH2nis7pIXMLh_eckwxcBlrRdlBeDZZxnc8cCCBZicSIpcGq4wUGeQczu0f5R65jcGwp_PSLb6JT?key=aUYzeFNHRDWEKfHvECRYag)
### Форма за Игра (Game Form)
Основната форма, където се провежда играта. Съдържа три бутона за избор (камък, ножица, хартия), един бутон “Restart”, който пуска играта наново, и pictureBox за визуализиране на избора. Включва и таймер, който отброява 5 секунди за всеки рунд. Има етикети (labels) за показване на резултата, броя спечелени игри и броя рундове които остават.

![](https://lh7-us.googleusercontent.com/docsz/AD_4nXeEJGUDlhRxfF5HRc2GaCrTiZ_cnAMV45wEfhEo4MSH6dPvF0hDCPxTnQx2zmwYbR5oe__m9_-qa64wPJGNJRGZADbSx3UDP_h79zHZPhNrvE589wCa6AD0sRbfmTMn3g7RjE8Vfct-jZpBvvalCJuhpr1R?key=aUYzeFNHRDWEKfHvECRYag)
## Функционалност

### Начало на играта: Форма за Вход (Login Form)
1. #### Въвеждане на име:
	- При стартиране на приложението, играчът се насочва към форма за вход, където трябва да въведе своето име в текстово поле. Това име ще бъде използвано за регистриране на резултатите от играта.
2. #### Бутон „Старт“:
	- След въвеждане на името, играчът натиска бутон „Старт“. Този бутон има за цел да премине към следващата форма - формата за игра. При натискането на бутона, програмата проверява дали името е въведено и ако не е, потребителят получава съобщение за грешка.  
	    ![](https://lh7-us.googleusercontent.com/docsz/AD_4nXc13GvFFtWUFCOg4sB3NM8CLzfl0Yh5pRnmHXNZO-HDdwbEmZdmfA62drT6qDeqsDf5TvNfoWjkNgMhDdXh2GKa_-qkG9iHTiHfzOd85Z_zDXivn5OZzzBiWiHhnyht_8Ah22HqXCxYdtgqJw3A1XgVrBnL?key=aUYzeFNHRDWEKfHvECRYag)
### Основен геймплей: Форма за Игра (Game Form)
- #### Елементи на интерфейса:
	- На формата за игра се намират три бутона, които представляват опциите на играча: Камък, ножица и хартия.
	- В централната част на формата се намират два pictureBox, които визуализира избора на играча и на компютъра.
	- Включени са и етикети (labels), които показват текущия резултат, броя секунди, броя победи и броя на оставащите рундове.
- #### Бутоните за избор:
	- Бутон „Камък“:
		- При натискане на този бутон, играчът избира „Камък“ като своя опция за текущия рунд.
		- Изображението на камъка се показва в pictureBox, като визуална обратна връзка за избора на играча.
		  ![](https://lh7-us.googleusercontent.com/docsz/AD_4nXcpTKMEdr1Eejt88pume2rFODdmCCFe1TOttk4x1j2cxigGzhAuWcBMX8Pq5ifW2Ae9S9n378p-LDzNmHNSbvNSBVIVoijEgsmasfOBo_N3vXXvEEJ6IdD8rLw9pBq5RtFAbjdvCdfqONW2xqMVreR6kdO0?key=aUYzeFNHRDWEKfHvECRYag)
	- Бутон „Ножица“:
		- При натискане на този бутон, играчът избира „Ножица“.
		- Изображението на ножицата се показва в pictureBox.                                                   
		  ![](https://lh7-us.googleusercontent.com/docsz/AD_4nXcQGBNXcRkGSvn4HrbYG7ASRDDdHI7TuJAux_6KRiMP3o0-prqKkMGImNcwNcXfirhlOlyiNXlhMi2S66xwg6c3GSBbZTYurRfIs43_vITpZQTXJsU_B4BR7oFnxFkAA65XkQ8Zv23Ea2p0PEN0V7uv3ME?key=aUYzeFNHRDWEKfHvECRYag)
	- Бутон „Хартия“:
		- При натискане на този бутон, играчът избира „Хартия“.
		- Изображението на хартия се показва в pictureBox.                                          
		  ![](https://lh7-us.googleusercontent.com/docsz/AD_4nXdJIZBr5iGYna_zBUN-NB3NbC6tQsRTT8m6mw7tUXolpe2yfMGEbYogX9AYGq2uOPSU3jz-CgVwDqSZRxMxX3WOC7x9j2Xqy7k-2nVYI1e6CuTSDAZ4GzrosHTLDnIDtw_G1eB_VGRfzSGFi3qQoK0i-P9g?key=aUYzeFNHRDWEKfHvECRYag)
- #### Избор на компютъра:
	- Компютърът избира своя ход на случаен принцип. Изборът се визуализира в друг pictureBox, разположен до този на играча.
- #### Определяне на победителя за рунда:
	- След като и играчът, и компютърът направят своите избори, логиката на играта сравнява двете опции, за да определи победителя:
		- Камък побеждава Ножица
		- Ножица побеждава Хартия
		- Хартия побеждава Камък                             
		  ![](https://lh7-us.googleusercontent.com/docsz/AD_4nXdMD76X6Y8sMGEsrv7eSaIORdoApuSxEHqR6EvfhQ4Dn54ACUBkglWgvQjlcgBxb6OJoaynN1te0lWAtQXC54haXkwwTOmBdkUVNIuTHULK4f0MNnxW9KtC6E2DBPrRh-E-vDluS4JG9d42sjawpotO2gcX?key=aUYzeFNHRDWEKfHvECRYag)
		- Равенство                                  
		  ![](https://lh7-us.googleusercontent.com/docsz/AD_4nXeQlqnjvisTu8cIijjAOFQ8NS-FldcqwFrJB80krEzGQuJfyTDOFBGwUe7r7eUongGh1xkqAAZGmegxuFmHj-yeeZtUWLjG0sbRjIMrqc2g9zWj0nh1FSZbiNm-8H9RZyrA_f_btatsxE0AND7wydfSztK0?key=aUYzeFNHRDWEKfHvECRYag)
	- Ако играчът спечели рунда, резултатът му се увеличава с 1 точка.
	- Ако играчът загуби рунда, точките на компютъра се увеличават с единица
	- Ако играчът не е натиснал нито един бутон, т.е. не е избрал нищо, излиза предупредително съобщение (MessageBox) и точката за рунда отива при резултата на компютъра                             
	  ![](https://lh7-us.googleusercontent.com/docsz/AD_4nXceUzpWMTb9Y1amP3C1E7MRYYWNWMzMZyCVIfxaIgahFB6iZ-MgXL4kDUXnUSAkjylmiyjqrMblGqRr_xuiqc_htFNoeTKHcDf2k5o3lUTUcAxw6znkPLMbgufs6F4dSwCNBBliSzDnrlvWSbYtAAy1Pc4m?key=aUYzeFNHRDWEKfHvECRYag)
- #### Таймер за рундове:
	- За всеки рунд има таймер от 5 секунди. През това време играчът може да си избира от бутоните за Камък, Ножица, Хартия.
	- След изтичане на таймера се показва избора на компютъра и излиза MessageBox, където пише кой е победил. След кликане на бутона “ОК” се активира следващият рунд.
- #### Край на играта:
	- Играта продължава 5 рунда. Защо точно 5? Защото е нечетно число и не е нито твърде много, нито твърде малко. След като всички рундове са изиграни, играта приключва и при наличие на повече точки от противника победите на играча се увеличават с една.
	- Ако потребителят затвори играта и отваряйки я, се регистрира със същото име то той броят на победите му ще бъде запазен. Това е така, защото имената на играчите и съответния им брой победи се запазват в файл “save.json”.
- #### Опции за нова игра:
	- Играчът може да избере да започне нова игра, като натисне бутонът за рестартиране.
	  ![](https://lh7-us.googleusercontent.com/docsz/AD_4nXe65N7w1CC42fl7f0JD9ksY200gMNP6HtGiJru1jackjR0Ni3b8RW-b0ev9t2hnzGbc4ArsyjHgTZdnygU0Zqwew4OAiIpKnJ9zvdbu6Mr4U4KDN2etzXEXv61DuhzzY6q_Tj41KOwTFO8V2VrVodiYDFwL?key=aUYzeFNHRDWEKfHvECRYag)
## Етапи при разработката
Идеята беше предложена от госпожа Юлия Димитрова от Математическа гимназия “Д-р Петър Берон”, Варна на 22.05.2029. 
1. ### Планиране 23.05:
	- Определихме целите и функциите на играта.
	- Разпределихме задачите в екипа
2. ### Дизайн 26.05:
	- Създадохме на концепцията за интерфейса на играта.
3. ### Разработка 27.05-10.06:
	- Програмирахме основната логика на играта.
	- Разработихме отделните форми и интеграцията им.
4. ### Тестване 11-12.06:
	- Тестове за функционалност и стабилност.
	- Тествахме потребителския интерфейс
5. ### Представяне 18-23.06:
	- Подготовка на документация.
	- Имаме финално представяне на проекта.
## Използвани технологии
- Програмен език: C#
- Среда за разработка: Microsoft Visual Studio
- Библиотеки: .NET Framework
- Инструменти: Windows Forms, PictureBox, Timer, Label, Button, TextBox, MessageBox
## Роли на всеки от екипа
- Виктор - UI дизайн, документация; 
- Димитър - UI дизайн, основен код на главната форма, документация; 
- Ясен - оптимизиране на кода на главната форма, код на “формата за Вход”
## Перспективи за развитие
- Разширяване на играта с нови функции:
- Добавяне на scoreboard
- Възможност за игра срещу друг потребител в мрежа.
- Подобряване на интерфейса: 
- Въвеждане на нови визуални елементи и анимации.
- Разширяване на функциите за класиране:
- Възможност за онлайн класиране и сравнение на резултатите с други играчи.
## Източници с линкове
- Документация на .NET Framework: [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/framework/)
- Ръководство за Windows Forms: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-8.0
- ChatGPT: https://chatgpt.com/
