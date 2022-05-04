# Ukrposhta

- Вирішення C# знаходиться в папці Project
- Вирішення Sql знаходиться у файлі Task_SQL.docx


- Проект розроблено на .Net 6
- Версія БД - PostgreSql 13.6


- В проекті є файл конфігурацій БД, знаходиться в Project\Common\DbSetting.json.
- В проекті додано міграції. Для розгортання БД необхідно ввести в package manager console команду update-database (вибрати default project DB). Або можна скористатись резервною копією - dumpDB.sql, яка знаходиться в корневій папці.
