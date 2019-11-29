# Left to do projekt

Programmet:
index
Når man skaber et nyt item, sendes index+=1 og text med = new Item("textinput", index+=1)


Superclass List
- liste 
- name
- print liste ($"{item.id} {item.text}")
- addItem (new item)


subclass ToDo : List
- name - override
- print liste(item.isFinished = false) - override
<!-- - getItem (liste[index]) - override -->
- addItem (new item) - override

subclass Archive : List
- name - override
- print liste(item.isFinished = true) - override

Item : List
- id
- text
- isFinished


Item repository : Item
<!-- jeg er i tvivl om hvor disse 2 skal ligge, hvem har ansvaret? -->
- retrieveItem (item[index] fra listen)
- editItemStatus (isDone = false)

Menu
StartMenu 
- add task
- print todo
- print archive
- archive items (uvirksom)
Submenu
- finished
- pending

