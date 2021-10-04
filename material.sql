CREATE TABLE material (
    material_code INT,
    merchandise_name VARCHAR(255),
    manufacture_number VARCHAR(255),
    quantity INT,
    unit_number INT,
    unit_name VARCHAR(255),
    price NUMERIC,
    total INT,
    delivery_date DATE,
    used_date DATE,
    attached_count INT,
    remake VARCHAR(255),
    stickynote VARCHAR(255),
    PRIMARY KEY(material_code)
);

INSERT INTO material VALUES (61122001, '押釦_TWX0001_WESN', 'TWX0001_WESN', 1234, 1, '式', 1234567.00, 1234567, '2021-09-11', '2021-09-11', 3, '押釦の使用は添付ファイル参照', '廃判になっており確認中');