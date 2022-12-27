create table manufacturers
(
    id   int identity
        constraint PK_manufacturers
            primary key,
    name nvarchar(32) not null
)
go

create unique index IX_manufacturers_name
    on manufacturers (name)
go

create table models
(
    id              int identity
        constraint PK_models
            primary key,
    name            nvarchar(32) not null,
    code            nvarchar(32) not null,
    start_date      datetime2,
    end_date        datetime2,
    manufacturer_id int          not null
        constraint FK_models_manufacturers_manufacturer_id
            references manufacturers
            on delete cascade
)
go

create table complectations
(
    id              int identity
        constraint PK_complectations
            primary key,
    name            nvarchar(32)            not null,
    start_date      datetime2               not null,
    end_date        datetime2               not null,
    engine          nvarchar(8) default N'' not null,
    grade           nvarchar(8) default N'' not null,
    transmission    nvarchar(8) default N'' not null,
    gear_shift_type nvarchar(8) default N'' not null,
    driver_position nvarchar(8) default N'' not null,
    destination     nvarchar(8) default N'' not null,
    fuel_induction  nvarchar(8) default N'' not null,
    model_id        int                     not null
        constraint FK_complectations_models_model_id
            references models
            on delete cascade
)
go

create index IX_complectations_model_id
    on complectations (model_id)
go

create unique index IX_complectations_name
    on complectations (name)
go

create index IX_complectations_name_start_date_end_date
    on complectations (name, start_date, end_date)
go

create index IX_models_manufacturer_id
    on models (manufacturer_id)
go

create index IX_models_name
    on models (name)
go

create unique index IX_models_name_code
    on models (name, code)
go

create index IX_models_name_code_start_date_end_date
    on models (name, code, start_date, end_date)
go

create table parts_groups
(
    id               int identity
        constraint PK_parts_groups
            primary key,
    name             nvarchar(32) not null,
    complectation_id int          not null
        constraint FK_parts_groups_complectations_complectation_id
            references complectations
            on delete cascade
)
go

create index IX_parts_groups_complectation_id
    on parts_groups (complectation_id)
go

create unique index IX_parts_groups_name
    on parts_groups (name)
go

create table parts_sub_groups
(
    id             int identity
        constraint PK_parts_sub_groups
            primary key,
    name           nvarchar(32) not null,
    parts_group_id int          not null
        constraint FK_parts_sub_groups_parts_groups_parts_group_id
            references parts_groups
            on delete cascade
)
go

create table parts
(
    id                int identity
        constraint PK_parts
            primary key,
    name              nvarchar(32)             not null,
    code              nvarchar(32)             not null,
    tree_code         nvarchar(32)             not null,
    count             int          default 0   not null,
    info              nvarchar(64) default N'' not null,
    start_date        datetime2                not null,
    end_date          datetime2                not null,
    image             nvarchar(64) default N'' not null,
    parts_subgroup_id int                      not null
        constraint FK_parts_parts_sub_groups_parts_subgroup_id
            references parts_sub_groups
            on delete cascade
)
go

create unique index IX_parts_name
    on parts (name)
go

create index IX_parts_name_start_date_end_date
    on parts (name, start_date, end_date)
go

create unique index IX_parts_name_tree_code_code
    on parts (name, tree_code, code)
go

create index IX_parts_parts_subgroup_id
    on parts (parts_subgroup_id)
go

create unique index IX_parts_sub_groups_name
    on parts_sub_groups (name)
go

create index IX_parts_sub_groups_parts_group_id
    on parts_sub_groups (parts_group_id)
go

