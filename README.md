# &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NIX Solutions Module #2 Homework #1


                                                      Задача
                     Необхідно реалізувати логгер (Logger), який збиратиме інформацію про стан додатка:
    
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Критерії\
● Логер пише на консоль інформацію у форматі “{час_лога}: {тип_лога}: {повідомлення}”\
● Типи лога: Error, Info, Warning\
● Вся логіка роботи логгера має бути в окремому файлі\
● Логер надає методи для взаємодії з ним.\
● Логер повинен реалізувати патерн (шаблон) проектування одинак (singleton)\
● Логер повинен зберігати весь текст звітів в оперативній пам'яті і при необхідності нього віддавати\
● Необхідно створити в окремому файлі клас Actions в якому буде 3 методи\
● Сигнатура методів в класі Actions: методи нічого не приймають і повертають об'єкт класу Result.\
● Клас Result містить властивості прапор Status і повідомлення про помилку якщо це необхідно\
● Методи в класі Actions повинні викликати логгер для того, щоб записати повідомлення в якому буде вказаний текст:\
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ 1 метод “Start method:” і ім'я цього методу. Ця балка має бути з типом Info.\
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Метод повертає Result де Status = true\
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ 2 метод “Skipped logic in method:” і ім'я цього методу. Ця балка має бути з типом Warning.\
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Метод повертає Result де Status = true\
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ 3 метод Метод повертає Result де властивість про помилку = “I broke a logic”. а Status = false\
● Створити в окремому файлі клас Starter з методом Run. Сигнатура методу нічого не приймає і не повертає.\
● Метод Run містить:\
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ Цикл(лічильник) на 100 ітерацій.\
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ Усередині циклу у випадковому порядку викликається один з 3х методів класу Actions\
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ Якщо метод повернув Result із значенням Status = false, то викликати логгер і записати в нього\
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;“Action failed by а reason:” і повідомлення про помилку з об'єкту Result.\
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Ця балка має бути з типом Error.\
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;○ По закінченню циклу сформувати файл в якому буде текст всіх записаних логів\

● В методі Main классу Program викликати метод Run\

Запис у файл зробити через File.WriteAllText("log.txt", {отриманий_лог});\
