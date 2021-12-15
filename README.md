# Разработка системы учета недвижимости.


# Содержание

[Введение](#introduction)

[1 Описание предметной области](#domainDescription)

[2 Сравнительный анализ ](#existingSoftware)

[3 Проектирование системы](#Systemdesign)

[4 Проверка и тестирование системы](#Checkingandtestingthesystem)

[Заключение](#Conclusion)

[Список литературы](#Listofliterature)

<a name="introduction"/> 

## Введение
В данном отчёте рассматривается разработка "Система учета агентство недвижимости". Система предназначена для введения систематизированного учета недвижимости. 
Покупка или продажа недвижимости должна происходить быстро и качественно, для этого и нужна система учета агентство недвижимости.

 
# 1 Описание предметной области
 Предметная область - "Система учета агентство недвижимости". Это область состоит из нескольких основных частей.
 Два основных аспекта предметной области.[<sup>[1.1]</sup>](#sourse_1.1)

Первая - это учет недвижимости. Учет не должен противоречить следующим общим правилам:
- недвижимость необходима для ведения основной деятельности нашей фирмы (продажа продукции, оказание услуг);
- объект эксплуатируется дольше года;
- фирма не планирует перепродажу;
- предполагается, что объект будет приносить финансовую выгоду; 

Второе - это особенности учета объектов у продавца. Если недвижимость была продана, ее стоимость списывается с учета. 
Выручка от реализации признается если: 
- у фирмы-продавца есть право собственности на объект, подтвержденное документами;
- сумма выручки от продажи известна;
- есть признаки того, что фирма получит экономическую выгоду от реализации;
- покупатель получил право собственности на объект.
 
 <a name="domainDescription"/>
 
 **Актуальность системы** 
 
В настоящее время большинству людей приходиться сталкиваться с проблемой покупки или продажи недвижимости с огромным количеством тягостной работы, такой как сортировка данных в договоре, денежный учет и оформление договора в ручную. Из этого вытекает множества минусов, такие как затрачивание достаточно большого количества времени и сил на всю сортировку документов и всевозможные утраты денежного ресурса. Но, если бы существовала система систематизированного учета недвижимости, то можно было бы сократить растрату человеческих ресурсов и повысить производительность, так как у системы есть систематизированность и учет всех данных. Так же с помощью простого интерфейса эта система является доступной для большинства.
 Информационная система необходима для того, чтобы все покупки и продажи недвижимости происходили систематизировано. Это поможет определить затраты и прибыль от заключённых договоров.
 В настоящее время происходят тысячи покупок и продаж какой-либо недвижимости. Это доказывает, что система актуальна.

Разработка системы учета недвижимости.
Эта работа показывает, как в интернете проходит покупка и продажа недвижимости, так же она покажет основные моменты этого рода занятий.

Показывает возможности клиента, продавца и возможности агента недвижимости. Эта система из за своего интерфейса является доступной для большинства пользователей интернета, даже тем кто полностью не разбирается в недвижимости. Она достаточно проста и в этом ее преимущество.




# 2. Сравнительный анализ

<a name="existingSoftware"/>

Существует множество различных систем учета недвижимости. Первым шагом к объединению систем учета и регистрации недвижимости в России послужило принятие в 2007 году Федерального закона от 24 июля 2007 г. № 221-ФЗ. Но и до этого момента в мире существовали различные системы учета недвижимости и вместе с ней использовался CRM.
Рассмотрим два популярных сайта, входящие в топ 12 лучших CRM для агентства недвижимости. Это Real Estate CRM.online 2.0 и INTRUM, узнаем их плюсы и минусы.[<sup>[1.2]</sup>](#sourse_1.2)

**Real Estate CRM.online 2.0**

Плюсы:
- автоматическая выгрузка рекламы освобождает больше половины рабочего времени для риелторов, и им меньше приходится общаться с клиентами;
- cистема фильтрует лишние объявления, и предоставляет только актуальные и качественные коммерческие и жилые объекты недвижимости в аренду или на продажу, содержащие телефоны собственников;
- переведена на разные языки;
- в ней есть настройки бизнес-процессов;

Минусы:
- расходы, связанные с внедрением;
- центр поддержки работает, только в рабочие дни;
- средняя скорость работы;

**INTRUM**

Плюсы:
- а CRM работает с более чем 200 рекламными площадками;
- настройки системы гибкие, можно загружать необходимые бизнес-процессы и функции, и убирать лишние;
- надежная защита баз данных за счет настройки прав доступа для сотрудников, чтобы никто не смог украсть информацию для своих целей или конкурентов;

Минусы:
- медленная скорость работ;
- местами трудные настройки;
- завышенная цена на тарифы;

Смотря на вышесказанные слова, можно понять проблемы данных платформ, и становится сразу понятно, что система "Система учета агентство недвижимости" превосходит их с помощью своей систематизации, быстрой скоростью работы, доступностью.

# 3. Проектирование системы
### 3.1 Проектирование системы <a name="проектирование"></a>
Проектирование состоит из трех этапов. В этом процессе используются основные идеи системного подхода и в полной мере проявляются его преимущества.  

Разработка начианется с проектрирования USE CASE диаграммы, отображающей основыне лица данной системы: Покупатель, Продавец, Агент по недвижимости.
<p align="center">
<img src="https://user-images.githubusercontent.com/91207739/146191628-3501d616-e136-42ba-9d6e-5116a944bb56.png"></p>
<p align="center">Рисунок 1 - USE CASE диаграмма</p>
<a name="Systemdesign"/>
 После на основе  USE CASE диаграммы создаетя диаграмма DFD (Data Flow Diagrams), которая наглядно отображает течение информации в системе.
 <p align="center">
<img src="https://user-images.githubusercontent.com/91207739/146193082-2aacc0ac-390c-4bd8-bbb7-e965206a4703.png"></p>
<p align="center">Рисунок 2 - DFD диаграмма</p>
 На основе DFD диаграммы создается сущность ER-диаграммы, которая показывает связи в системе.
  <p align="center">
<img src="https://user-images.githubusercontent.com/91207739/146194341-a105a8df-5d2b-4a18-9d8b-7ce67dd95072.png"></p>
<p align="center">Рисунок 2 - ER-диаграмма</p>
<a name="Systemdesign"/>

***

### 3.2 Реализация системы <a name="реализация"></a>

Реализация системы  начинается с ER-диаграммы создаются классы. 
```csharp
public class AgencyAccount: IIdentifier
    {
        public int Id { get; set; }
        public int AgencyAccountid { get; set;}
        public int OperationNumber { get; set;}
    {
```   
# 4. Проверка и тестирование системы

<a name="Checkingandtestingthesystem"/>

# Заключение

<a name="Conclusion"/>

# Список литературы

<a name="Listofliterature"/>

<a name="sourse_1.1">

[1.1 Источник данных правил учета недвижимости](https://assistentus.ru/buhuchet/obektov-nedvizhimosti/) 


<a name="sourse_1.2">

[1.2 Источник данных сравнительного анализа](https://otzyvmarketing.ru/articles/12-luchshih-crm-dlya-agentstva-nedvizhimosti/).

