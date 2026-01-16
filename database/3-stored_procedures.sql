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
