create table db_owner.Client
(
    Client_ID int identity (100, 1)
        constraint Client_pk
            primary key,
    Name      nvarchar(100) not null,
    Gender    char,
    Age       int           not null
)
go

create table db_owner.Worker
(
    Staff_ID int identity (100, 2)
        constraint Worker_pk
            primary key,
    Name     nvarchar(100) not null,
    Phone#   nvarchar(10)  not null,
    Position nvarchar(50)
)
go

create table db_owner.Class
(
    Class_ID  int identity (100, 1)
        constraint Class_pk
            primary key,
    Date      date not null,
    StartTime int  not null,
    Staff_ID  int  not null
        constraint Class_Worker_Staff_ID_fk
            references db_owner.Worker
            on update cascade on delete cascade,
    Client_ID int  not null
        constraint Class_Client_Client_ID_fk
            references db_owner.Client
            on update cascade on delete cascade
)
go

