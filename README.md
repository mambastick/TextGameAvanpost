﻿Постарался учесть все требования и у меня получилось поиграть вот так:
```
Добро пожаловать в текстовую игру!
Введите команду 'осмотреться', чтобы начать.
> осмотреться 
Вы находитесь в коридор, на столе лежат предметы: ключи, а пройти можно в: кухня, комната, улица
> поднять
Вы не указали, что хотите поднять!
> поднять ключи
Вы положили в рюкзак: ключи
> рюкзак
Ваш инвентарь:
ключи
> идти комната
Вы перешли в комната.
Вы находитесь в комната, на столе лежат предметы: конспекты, а пройти можно в: коридор
> поднять конспекты
Вы положили в рюкзак: конспекты
> рюкзак
Ваш инвентарь:
ключи
конспекты
> идти коридор
Вы перешли в коридор.
Вы находитесь в коридор, на столе лежат предметы: , а пройти можно в: кухня, комната, улица
> идти кухня
Вы перешли в кухня.
Вы находитесь в кухня, на столе лежат предметы: рюкзак, а пройти можно в: коридор
> поднять рюкзак
Вы положили в рюкзак: рюкзак
> идти коридор
Вы перешли в коридор.
Вы находитесь в коридор, на столе лежат предметы: , а пройти можно в: кухня, комната, улица
> идти улица
Вы перешли в улица.
Вы находитесь в улица, на столе лежат предметы: , а пройти можно в: коридор
>
```

я бы, конечно, доработал некоторые моменты, например:
- Улучшить локации, класс Location можно сделать абстрактным, а от него уже создавать RoomLocation, KitchenLocation и т.д.
- Всякие проверки на команды, например, нести больше 1 предмета нельзя, если отсутствует рюкзак
- Добавить игроку несколько новых параметров, такие как: здоровье, сытость и так далее

но так как это всего лишь тестовый вариант, я решил не тратить на это время