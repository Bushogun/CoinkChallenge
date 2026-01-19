CREATE OR REPLACE PROCEDURE sp_create_user(
    p_name VARCHAR,
    p_phone VARCHAR,
    p_address TEXT,
    p_municipality_id INT
)
LANGUAGE plpgsql
AS $$

BEGIN
    INSERT INTO users (name, phone, address, municipality_id)
    VALUES (p_name, p_phone, p_address, p_municipality_id);
END;
$$;

CREATE OR REPLACE FUNCTION sp_get_users()
RETURNS TABLE (
    id users.id%TYPE,
    name users.name%TYPE,
    phone users.phone%TYPE,
    address users.address%TYPE,
    municipality_id users.municipality_id%TYPE
)
LANGUAGE plpgsql
AS $$
BEGIN
    RETURN QUERY
    SELECT
        u.id,
        u.name,
        u.phone,
        u.address,
        u.municipality_id AS "MunicipalityId"
    FROM users u
    ORDER BY u.name;
END;
$$;


CREATE OR REPLACE FUNCTION sp_get_municipalities()
RETURNS TABLE (
    id INT,
    name VARCHAR,
    department_id INT
)
LANGUAGE plpgsql
AS $$
BEGIN
    RETURN QUERY
    SELECT 
        m.id,
        m.name,
        m.department_id
    FROM municipality m
    ORDER BY m.name;
END;
$$;
