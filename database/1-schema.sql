CREATE TABLE country (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE department (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    country_id INT NOT NULL,
    CONSTRAINT fk_department_country
        FOREIGN KEY (country_id) REFERENCES country(id),
    CONSTRAINT uq_department UNIQUE (name, country_id)
);

CREATE TABLE municipality (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    department_id INT NOT NULL,
    CONSTRAINT fk_municipality_department
        FOREIGN KEY (department_id) REFERENCES department(id),
    CONSTRAINT uq_municipality UNIQUE (name, department_id)
);

CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    name VARCHAR(150) NOT NULL,
    phone VARCHAR(20) NOT NULL,
    address TEXT NOT NULL,
    municipality_id INT NOT NULL,
    CONSTRAINT fk_user_municipality
        FOREIGN KEY (municipality_id) REFERENCES municipality(id)
);
