
/*
select concat(LIVROS.nomeLivro, '- Exemplar') as 'Livros', concat(CATEGORIA.nomeCategoria, ' - Categoria') as 'Categorias', concat(AUTORES.nomeAutor, ' - Autores') as 'Autores', 
		concat(EDITORA.nomeEditora, ' - Editora') as 'Editoras' from LIVROS inner join CATEGORIA inner join AUTORES inner join EDITORA 
        where LIVROS.nomeLivro like concat('%','a','%') or CATEGORIA.nomeCategoria like concat('%','a','%') 
        or EDITORA.nomeEditora like concat('%','a','%')  or AUTORES.nomeAutor like concat('%','a','%');
*/

-- call pesquisar('');
/*
select concat(AUTORES.nomeAutor, '- Autores') as 'Autores' from AUTORES where nomeAutor like concat('%','al','%');
*/

/*
DELIMITER $$
create procedure pesquisar(parm varchar(255))
BEGIN
	select nomeLivro from LIVROS where nomeLivro like concat('%',parm,'%');
    select nomeCategoria from CATEGORIA where nomeCategoria like concat('%',parm,'%');
    select nomeAutor from AUTORES where nomeAutor like concat('%',parm,'%');
    select nomeEditora from EDITORA where nomeEditora like concat('%',parm,'%');
END ; $$
DELIMITER ;

*/


/*DELIMITER $$
create procedure pesquisar_tudo(parm varchar(255), parmLim int)
BEGIN
	(select concat(AUTORES.nomeAutor, ' - Autores') as 'Resultados' from AUTORES where nomeAutor like concat('%',parm,'%')) UNION
	(select concat(CATEGORIA.nomeCategoria, ' - Categoria') from CATEGORIA where nomeCategoria like concat('%',parm,'%')) UNION
	(select concat(LIVROS.nomeLivro, '- Exemplar') from LIVROS where nomeLivro like concat('%',parm,'%')) UNION
	(select concat(EDITORA.nomeEditora, ' - Editora') from EDITORA where nomeEditora like concat('%',parm,'%')) limit parmLim;
END ; $$
DELIMITER ;*/





call pesquisar_livros('i',20);    
call pesquisar_editora('m',20);
call pesquisar_categoria('m',20);
call pesquisar_editora('m',20);
