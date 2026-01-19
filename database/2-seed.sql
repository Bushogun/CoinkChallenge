INSERT INTO country (name) VALUES
('Colombia'),
('México'),
('Argentina');


INSERT INTO department (name, country_id) VALUES
('Valle del Cauca', 1),
('Antioquia', 1),
('Cundinamarca', 1),
('Atlántico', 1),

('Ciudad de México', 2),
('Jalisco', 2),
('Nuevo León', 2),

('Buenos Aires', 3),
('Córdoba', 3),
('Santa Fe', 3);


INSERT INTO municipality (name, department_id) VALUES
('Cali', 1),
('Palmira', 1),
('Buenaventura', 1),

('Medellín', 2),
('Envigado', 2),
('Itagüí', 2),

('Bogotá', 3),
('Soacha', 3),
('Chía', 3),

('Barranquilla', 4),
('Soledad', 4),

('Cuauhtémoc', 5),
('Coyoacán', 5),

('Guadalajara', 6),
('Zapopan', 6),

('Monterrey', 7),
('San Pedro Garza García', 7),

('La Plata', 8),
('Mar del Plata', 8),

('Córdoba Capital', 9),
('Villa Carlos Paz', 9),

('Rosario', 10),
('Santa Fe Capital', 10);