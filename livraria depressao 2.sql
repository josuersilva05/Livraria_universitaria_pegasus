create database livraria_depressao2;
use livraria_depressao2;

create table CLIENTE (
	idCliente int auto_increment primary key,
	nomeCliente varchar(65) not null,
    sexo enum('f','m','i') not null,
	cpf varchar(14) not null,
	email varchar(55) not null,
	celular varchar(15) not null,
    statusCliente enum('regularizado','nao_regularizado')
 );
 create table FUNCIONARIOS (
	idFuncionario int auto_increment primary key,
    nomeFuncionario varchar(65) not null, 
    cargo varchar(25) not null,
    sexo enum('f','m','i') not null
);
create table LOGIN(
	idUsuarioLogin int auto_increment primary key,
	idFuncionario int,
    nomeUsuario varchar(30) not null,
    senha varchar(40) not null,
    permissao enum('admin','comum'),
	constraint fk_idFuncionarioLog foreign key (idFuncionario) references FUNCIONARIOS(idFuncionario)
);
create table AUTORES (
	idAutor int auto_increment primary key,
    nomeAutor varchar(50) not null
);
create table CATEGORIA (
	idCategoria int auto_increment primary key, 
    nomeCategoria varchar(25) not null
);
create table EDITORA (
	idEditora int auto_increment primary key, 
    nomeEditora varchar(45) not null
);
create table LIVROS (
	idLivro int auto_increment primary key, 
    idCategoria int,
    idAutor int,
    idEditora int,
	nomeLivro varchar(60) not null,
    isbn varchar(19),
    qtd int not null,
    precoUnidade float,
    constraint fk_idCategoriaLiv foreign key (idCategoria) references CATEGORIA(idCategoria),
    constraint fk_idAutorLiv foreign key (idAutor) references AUTORES(idAutor),
    constraint fk_idEditoraLiv foreign key (idEditora) references EDITORA(idEditora)
);
create table EMPRESTIMOS (
	idEmprestimo int auto_increment primary key,
    idFuncionario int,
    idCliente int,
    idLivro int,
    dataPedido datetime not null,
    dataPrevistaEntrega datetime not null,
    dataEntrega datetime,
    totalEmprestimo float not null,   
    statusEmprestimo enum("pontual", "atraso", "danificado", "perca") not null,
    reservado enum('sim','nao'),
    constraint fk_idFuncionarioEmp foreign key (idFuncionario) references FUNCIONARIOS(idFuncionario),
    constraint fk_idClienteEmp foreign key (idCliente) references CLIENTE(idCliente),
    constraint fk_idLivroEmp foreign key (idLivro) references LIVROS(idLivro)
);
create table RESERVA (
	idReserva int auto_increment primary key,
    idCliente int, 
    idFuncionario int,
    idLivro int, 
    idEmprestimo int,
    dataReserva datetime not null,
    dataRetiradaPrevista datetime not null,
    dataRetirada datetime,
    statusReserva enum('espera', 'adiado', 'cancelado', 'concluida') not null,
    constraint fk_idLivroRes foreign key(idLivro) references LIVROS(idLivro),
    constraint fk_idClienteRes foreign key (idCliente) references CLIENTE(idCliente),
    constraint fk_idFuncionarioRes foreign key (idFuncionario) references FUNCIONARIOS(idFuncionario),
    constraint fk_idEmprestimoRes foreign key(idEmprestimo) references EMPRESTIMOS(idEmprestimo)
); 
create table TIPOS_MULTA (
	idTipoMulta int auto_increment primary key,
    nomeTipo varchar(25) not null,
    valor float not null
);
create table MULTA (
	idMulta int auto_increment primary key, 
    idTipoMulta int,
    idEmprestimo int,
    idFuncionario int,
	observacoes varchar(255),
    statusMulta enum('paga','devendo','abono') not null,
    totalMulta float not null,
    constraint fk_idTipoMultaMul foreign key (idTipoMulta) references TIPOS_MULTA(idTipoMulta),
    constraint fk_idEmprestimoMul foreign key (idEmprestimo) references EMPRESTIMOS(idEmprestimo),
    constraint fk_idFuncionarioMul foreign key (idFuncionario) references FUNCIONARIOS(idFuncionario)
);


select * from login;

-- ////////////// PESQUISA

create procedure pesquisar_livros(parm varchar(255), parmLim int)
		select LIVROS.idLivro, LIVROS.nomeLivro from LIVROS where nomeLivro like concat('%',parm,'%') limit parmLim;
        
create procedure pesquisar_livros_id(parmId varchar(255), parmLim int)
	select LIVROS.idLivro, LIVROS.nomeLivro from LIVROS where idLivro like concat(parmId,'%') limit parmLim;

DELIMITER $$
create procedure pesquisar_disponibilidade_livro(parmId int)
BEGIN 	
	DECLARE QTD INT DEFAULT 0;
    select count(EMPRESTIMOS.idEmprestimo) from EMPRESTIMOS where EMPRESTIMOS.idLivro = parmId and EMPRESTIMOS.dataEntrega is Null into QTD;
    IF QTD is Null THEN
		select LIVROS.qtd from LIVROS where idLivro = parmId;
	ELSE
		select LIVROS.qtd - QTD from LIVROS where idLivro = parmId;
    END IF ;
END ; $$
DELIMITER ;

create procedure pesquisar_autor(parm varchar(255), parmLim int)
	select LIVROS.idLivro as 'ID Livro', AUTORES.nomeAutor as 'Autor', LIVROS.nomeLivro as 'Livro' from AUTORES inner join LIVROS 
    on AUTORES.idAutor = LIVROS.idAutor where AUTORES.nomeAutor like concat('%',parm,'%') limit parmLim;

create procedure pesquisar_categoria(parm varchar(255), parmLim int)
	select LIVROS.idLivro as 'ID Livro', CATEGORIA.nomeCategoria as 'Categoria', LIVROS.nomeLivro as 'Livro' from CATEGORIA inner join LIVROS 
    on CATEGORIA.idCategoria = LIVROS.idCategoria where CATEGORIA.nomeCategoria like concat('%',parm,'%') limit parmLim;
   
create procedure pesquisar_editora(parm varchar(255), parmLim int)
	select LIVROS.idLivro as 'ID Livro', EDITORA.nomeEditora as 'Editora', LIVROS.nomeLivro as 'Livro' from EDITORA inner join LIVROS
    on EDITORA.idEditora = LIVROS.idEditora where EDITORA.nomeEditora like concat('%',parm,'%') limit parmLim;  
           
DELIMITER $$         
create procedure pesquisar_cliente(parm varchar(255), parmColuna char(5))    
    BEGIN
		IF parmColuna = 'nome' THEN
			select idCliente, nomeCliente, cpf, email, statusCliente, celular, sexo from CLIENTE where nomeCliente like concat('%',parm,'%');
		ELSEIF parmColuna = 'cpf' THEN
			select idCliente, nomeCliente, cpf, email, statusCliente, celular, sexo from CLIENTE where cpf like concat('%',parm,'%');
        ELSEIF parmColuna = 'id' THEN
			select idCliente, nomeCliente, cpf, email, statusCliente, celular, sexo from CLIENTE where idCliente like concat(parm,'%');
        END IF ;
    END ; $$
DELIMITER ;    
        
create procedure pesquisar_cliente_regularizado(parm varchar(255))    
	select idCliente, nomeCliente from CLIENTE where nomeCliente like concat('%',parm,'%') and statusCliente = "regularizado";

    
    
    
    
    
    
    
    
    
    
    
    
-- ////////////// LIVROS

create procedure editar_livro(parmIdLivro int, parmCategoria int, parmAutor int, parmEditora int, parmQtd int, parmNome varchar(60), parmIsbn varchar(19), parmPrecoUnidade float)    
	update LIVROS set idCategoria = parmCategoria, idAutor = parmAutor, idEditora = parmEditora, qtd = parmQtd, nomeLivro = parmNome, isbn = parmIsbn, precoUnidade = parmPrecoUnidade where idLivro = parmIdLivro;

create procedure carregar_livros()
	select LIVROS.idLivro, LIVROS.nomeLivro, AUTORES.nomeAutor, CATEGORIA.nomeCategoria, EDITORA.nomeEditora, LIVROS.isbn, LIVROS.qtd, LIVROS.precoUnidade 
    from LIVROS inner join AUTORES on AUTORES.idAutor = LIVROS.idAutor inner join CATEGORIA on CATEGORIA.idCategoria = LIVROS.idCategoria 
    inner join EDITORA on EDITORA.idEditora = LIVROS.idEditora;

create procedure pesquisa_editar_livro(parmId int)
	select idCategoria, idAutor, idEditora from LIVROS where idLivro = parmId;

create procedure cadastrar_livro(parmCategoria int, parmAutor int, parmEditora int, parmQtd int, parmNome varchar(60), parmIsbn varchar(19), parmPreco float)    
	insert into LIVROS(idLivro, idCategoria, idAutor, idEditora, qtd, nomeLivro, isbn, precoUnidade) values(NULL,parmCategoria, parmAutor, parmEditora, parmQtd, parmNome, parmIsbn, parmPreco);
       
create procedure excluir_livro(parmId int)
	delete from LIVROS where idLivro = parmId;



-- ////////////// CATEGORIAS

create procedure cadastrar_categoria(parmNome varchar(25))
	insert into CATEGORIA(nomeCategoria) values(parmNome);

create procedure carregar_categorias()
	select * from CATEGORIA;

create procedure editar_categoria(parmId int, parmNome varchar(25))
	update CATEGORIA set nomeCategoria = parmNome where idCategoria = parmId;



-- ////////////// AUTORES
   
create procedure cadastrar_autor(parmNome varchar(50))
	insert into AUTORES(nomeAutor) values(parmNome);

create procedure editar_autor(parmId int, parmNome varchar(50))
	update AUTORES set nomeAutor = parmNome where idAutor = parmId;
        
create procedure carregar_autores()
	select * from AUTORES;
    
 

-- ////////////// EDITORAS

create procedure cadastrar_editora(parmNome varchar(45))
	insert into EDITORA(nomeEditora) values(parmNome);

create procedure carregar_editoras()
	select * from EDITORA;
    
create procedure editar_editora(parmId int, parmNome varchar(45))
	update EDITORA set nomeEditora = parmNome where idEditora = parmId;




-- ////////////// FUNCIONARIOS    

create procedure carregar_funcionarios()
	select * from FUNCIONARIOS;
     
create procedure cadastrar_funcionario(parmNome varchar(65), parmCargo varchar(25), parmSexo enum('f','m','i'))
	insert into FUNCIONARIOS(nomeFuncionario, cargo, sexo) values(parmNome, parmCargo, parmSexo);

create procedure editar_funcionario(parmCodigo int, parmNome varchar(65), parmCargo varchar(25), parmSexo enum('f','m','i'))
    update FUNCIONARIOS set nomeFuncionario = parmNome, cargo = parmCargo, sexo = parmSexo where idFuncionario = parmCodigo;

DELIMITER $$
create procedure excluir_funcionario(parmId int)
	BEGIN
		DECLARE cont smallint default 0;
		select idFuncionario from LOGIN where idFuncionario = parmId;
		IF cont > 0 THEN
			delete from LOGIN where idFuncionario = parmId;
		END IF;
        delete from FUNCIONARIOS where idFuncionario = parmId;
    END ; $$
DELIMITER ;    
    
    
    

-- ////////////// USUARIOS

DELIMITER $$
create procedure cadastrar_usuario(parmId int, parmNome varchar(30), parmSenha varchar(40), parmPermissao enum('admin','comum'))
	BEGIN
		DECLARE cont smallint default 0;
		select count(idFuncionario) from FUNCIONARIOS where idFuncionario = parmId  into cont;
		IF (cont = 1) THEN
			insert into LOGIN(idFuncionario, nomeUsuario, senha, permissao) values(parmId, parmNome, parmSenha, parmPermissao);
		ELSE
			SELECT "Nenhum registro encontrado." AS 'ERRO';
		END IF;
	END $$ ;
DELIMITER ;

create procedure carregar_usuarios()
	select LOGIN.idFuncionario, LOGIN.nomeUsuario, LOGIN.permissao, FUNCIONARIOS.nomeFuncionario, FUNCIONARIOS.cargo from LOGIN
		inner join FUNCIONARIOS where LOGIN.idFuncionario = FUNCIONARIOS.idFuncionario;

create procedure verifica_login(parmUsuario varchar(30), parmSenha varchar(40))
	select LOGIN.idFuncionario, LOGIN.permissao, FUNCIONARIOS.nomeFuncionario, FUNCIONARIOS.cargo, FUNCIONARIOS.sexo from LOGIN 
    inner join FUNCIONARIOS on FUNCIONARIOS.idFuncionario = LOGIN.idFuncionario where nomeUsuario = parmUsuario and senha = parmSenha;

create procedure verifica_senha(parmId int, parmUsuario varchar(30), parmSenha varchar(40))
	select LOGIN.senha from LOGIN where idFuncionario = parmId and senha = parmSenha;
    
create procedure alterar_senha(parmId int, parmUsuario varchar(30), parmSenha varchar(40))
	update LOGIN set senha = parmSenha where idFuncionario = parmId and nomeUsuario = parmUsuario;

create procedure editar_usuario_admin(parmId int, parmUsuario varchar(30), parmPermissao enum('admin','comum'))
	update LOGIN set nomeUsuario = parmUsuario, permissao = parmPermissao where idFuncionario = parmId;
    
create procedure excluir_usuario(parmId int, parmNome varchar(30))
	delete from LOGIN where idFuncionario = parmId and nomeUsuario = parmNome;

DELIMITER $$
create procedure editar_perfil(parmId int, parmUsuarioAtual varchar(30), parmNome varchar(65), parmSexo enum('f','m','i'), parmUsuario varchar(30))
	BEGIN
    DECLARE result smallint default 0;
    select count(LOGIN.idFuncionario) from LOGIN inner join FUNCIONARIOS on LOGIN.idFuncionario = FUNCIONARIOS.idFuncionario where LOGIN.idFuncionario = parmId and LOGIN.nomeUsuario = parmUsuarioAtual into result;
    if result >= 1 then
		update LOGIN set nomeUsuario = parmUsuario where idFuncionario = parmId and nomeUsuario = parmUsuarioAtual;
        update FUNCIONARIOS set nomeFuncionario = parmNome, sexo = parmSexo where idFuncionario = parmId;
	end if ;
	END ; $$
DELIMITER ;


    
-- //////////////  CLIENTES

create procedure cadastrar_cliente(parmNome varchar(65), parmCpf varchar(14), parmEmail varchar(55), parmCel varchar(15), parmStatus enum('regularizado','nao_regularizado'), parmSexo enum('f','m','i'))
		insert into CLIENTE(idCliente, nomeCliente, cpf, email, celular, statusCliente, sexo) values(null, parmNome, parmCpf, parmEmail, parmCel, parmStatus, parmSexo);
        
create procedure editar_cliente(parmIdCliente int, parmNome varchar(65), parmCpf varchar(14), parmEmail varchar(55), parmCel varchar(15), parmStatus enum('regularizado','nao_regularizado'), parmSexo enum('f','m','i'))
        update CLIENTE set nomeCliente = parmNome, cpf = parmCpf, email = parmEmail, celular = parmCel, statusCliente = parmStatus, sexo = parmSexo where idCliente = parmIdCliente;

create procedure excluir_cliente(parmId int)
	delete from CLIENTE where idCliente = parmId;

create procedure carregar_clientes_emprestimo()
	select idCliente, nomeCliente from CLIENTE where statusCliente = 'regularizado';

create procedure carregar_clientes()
	select idCliente, nomeCliente, cpf, email, statusCliente, celular, sexo from CLIENTE;





-- //////////////  EMPRESTIMOS

-- call cadastrar_emprestimo(NOW(), 11, 3, 2, 5.0);

select * from cliente;
select * from livros;
create procedure cadastrar_emprestimo(parmEntrega datetime, parmIdFuncionario int, parmIdCliente int, parmIdLivro int, parmTotal float)
		insert into EMPRESTIMOS(idEmprestimo, dataPedido, dataPrevistaEntrega, statusEmprestimo, idFuncionario, idCliente, idLivro, totalEmprestimo) values(null, NOW(), parmEntrega, 'pontual', parmIdFuncionario, parmIdCliente, parmIdLivro, parmTotal);

create procedure entregar_hoje()
	select EMPRESTIMOS.idEmprestimo, EMPRESTIMOS.dataPedido, EMPRESTIMOS.dataPrevistaEntrega, CLIENTE.nomeCliente, FUNCIONARIOS.nomeFuncionario, LIVROS.nomeLivro    
    from EMPRESTIMOS inner join CLIENTE on EMPRESTIMOS.idCliente = CLIENTE.idCliente 
							  inner join FUNCIONARIOS on EMPRESTIMOS.idFuncionario = FUNCIONARIOS.idFuncionario 
                              inner join LIVROS on EMPRESTIMOS.idLivro = LIVROS.idLivro
                              where dataPrevistaEntrega = CURDATE();

create procedure atualizar_emprestimo(parmId int, parmDataEntrega datetime, parmStatus enum('pontual','atraso','danificado','perca'))
	update EMPRESTIMOS set statusEmprestimo = parmStatus, dataEntrega = parmDataEntrega where idEmprestimo = parmId;

DELIMITER $$
create procedure carregar_emprestimos()
BEGIN
	select EMPRESTIMOS.idEmprestimo, EMPRESTIMOS.dataPedido, EMPRESTIMOS.dataPrevistaEntrega, EMPRESTIMOS.dataEntrega, EMPRESTIMOS.statusEmprestimo, 
	FUNCIONARIOS.nomeFuncionario, CLIENTE.nomeCliente, LIVROS.nomeLivro, EMPRESTIMOS.totalEmprestimo
    from EMPRESTIMOS inner join FUNCIONARIOS on EMPRESTIMOS.idFuncionario = FUNCIONARIOS.idFuncionario
    inner join CLIENTE on EMPRESTIMOS.idCliente = CLIENTE.idCliente
    inner join LIVROS on EMPRESTIMOS.idLivro = LIVROS.idLivro order by EMPRESTIMOS.dataPrevistaEntrega limit 40;
END ; $$
DELIMITER ;

DELIMITER $$
create procedure carregar_emprestimos_hoje()
BEGIN
	select EMPRESTIMOS.idEmprestimo, LIVROS.nomeLivro, CLIENTE.nomeCliente, EMPRESTIMOS.dataPedido, EMPRESTIMOS.dataPrevistaEntrega, FUNCIONARIOS.nomeFuncionario
    from EMPRESTIMOS inner join FUNCIONARIOS on EMPRESTIMOS.idFuncionario = FUNCIONARIOS.idFuncionario
    inner join CLIENTE on EMPRESTIMOS.idCliente = CLIENTE.idCliente
    inner join LIVROS on EMPRESTIMOS.idLivro = LIVROS.idLivro where DATE(EMPRESTIMOS.dataPrevistaEntrega) = CURDATE();
END ; $$
DELIMITER ;

DELIMITER $$
create procedure carregar_emprestimo_multa(parmId int)
	BEGIN
		DECLARE multa char(3) default "Não";
        select (CASE WHEN (select count(idMulta) from MULTA inner join EMPRESTIMOS on MULTA.idEmprestimo = EMPRESTIMOS.idEmprestimo 
        where MULTA.idEmprestimo = parmId) = 0 THEN "Não" ELSE "Sim" END) as multa;
    END ; $$
DELIMITER ;

create procedure carregar_detalhes_emprestimo(parmId int)
	select distinct TIPOS_MULTA.nomeTipo, TIPOS_MULTA.valor, MULTA.statusMulta, MULTA.totalMulta from MULTA inner join TIPOS_MULTA 
    on MULTA.idTipoMulta = TIPOS_MULTA.idTipoMulta where MULTA.idEmprestimo = parmId;




-- //////////////  RESERVAS

desc reserva;

DELIMITER $$
create procedure carregar_reservas()
BEGIN
	select RESERVA.idReserva, LIVROS.nomeLivro, CLIENTE.nomeCliente, RESERVA.dataReserva, RESERVA.dataRetiradaPrevista, RESERVA.dataRetirada, RESERVA.idEmprestimo, RESERVA.statusReserva, FUNCIONARIOS.nomeFuncionario
    from RESERVA inner join LIVROS on LIVROS.idLivro = RESERVA.idLivro inner join CLIENTE on CLIENTE.idCliente = RESERVA.idCliente inner join FUNCIONARIOS on FUNCIONARIOS.idFuncionario = RESERVA.idFuncionario
    where RESERVA.statusReserva = 'espera' or RESERVA.statusReserva = 'adiado' or (RESERVA.statusReserva = 'concluida' and DATEDIFF(RESERVA.dataRetirada, NOW()) <= 1);
END ; $$
DELIMITER ;

create procedure cadastrar_reserva(parmIdCliente int, parmIdFuncionario int, parmIdLivro int, parmIdEmprestimo int, parmRetiradaPrevista datetime)
	insert into RESERVA(idReserva, idCliente, idFuncionario, idLivro, dataReserva, dataRetirada, statusReserva, idEmprestimo, dataRetiradaPrevista) values(null, parmIdCliente, parmIdFuncionario, parmIdLivro, NOW(), null, 'espera', parmIdEmprestimo, parmRetiradaPrevista);

DELIMITER $$
create procedure atualizar_reserva(parmId int, parmStatus enum('espera','adiado','cancelado','concluida'), parmDataRetiradaPrevista datetime)
BEGIN
	if parmStatus = 'concluida' then
		update RESERVA set statusReserva = parmStatus, dataRetiradaPrevista = parmDataRetiradaPrevista, dataRetirada = NOW() where idReserva = parmId;
	else
		update RESERVA set statusReserva = parmStatus, dataRetiradaPrevista = parmDataRetiradaPrevista where idReserva = parmId;
    end if ;
END ; $$
DELIMITER ;
create procedure selecionar_emprestimos_disponiveis(parmIdLivro int)
	select idEmprestimo, dataPrevistaEntrega from EMPRESTIMOS where idLivro = parmIdLivro and dataEntrega is null;  
        
create procedure pesquisar_idClienteLivro(parmId int)
	select idCliente, idLivro from RESERVA where idReserva = parmId;	
    
DELIMITER $$
create trigger concluir_reserva BEFORE UPDATE ON RESERVA
FOR EACH ROW
	BEGIN 
		IF OLD.statusReserva <> NEW.statusReserva and NEW.statusReserva = 'concluida' THEN
			UPDATE RESERVA set dataRetirada = NOW() where idReserva = OLD.idReserva;
        END IF ;
    END ; $$	
DELIMITER ;





-- //////////////  MULTAS

desc multa;
create procedure cadastrar_tipo_multa(parmNome varchar(25), parmValor float)
	insert into TIPOS_MULTA(idTipoMulta, nomeTipo, valor) values(null, parmNome, parmValor);
                
create procedure editar_tipo_multa(parmId int, parmNome varchar(25), parmValor float)
    update TIPOS_MULTA set nomeTipo = parmNome, valor = parmValor where idTipoMulta = parmId;

create procedure carregar_tipos_multa()
	select * from TIPOS_MULTA;
    
create procedure excluir_multa(parmId int)
	delete from TIPOS_MULTA where idTipoMulta = parmId;

create procedure cadastrar_multa(parmIdTipo int, parmIdEmprestimo int, parmIdFuncionario int, parmObservacoes varchar(255), parmStatus enum('paga','devendo','abono'), parmTotal float)
	insert into MULTA(idMulta, idTipoMulta, idEmprestimo, idFuncionario, observacoes, statusMulta, totalMulta) values(null, parmIdTipo, parmIdEmprestimo, parmIdFuncionario, parmObservacoes, parmStatus, parmTotal);

create procedure atualizar_multa_emprestimo_paga(parmId int)
	update MULTA set statusMulta = 'paga' where idEmprestimo = parmId;
    
DELIMITER $$    
create procedure carregar_multas()
BEGIN
	select MULTA.idMulta, LIVROS.nomeLivro, CLIENTE.nomeCliente, EMPRESTIMOS.idEmprestimo, MULTA.statusMulta, TIPOS_MULTA.nomeTipo, TIPOS_MULTA.valor, DATEDIFF(CURDATE(), EMPRESTIMOS.dataPrevistaEntrega) as 'Dias atraso', FUNCIONARIOS.nomeFuncionario 
    from MULTA inner join EMPRESTIMOS on MULTA.idEmprestimo = EMPRESTIMOS.idEmprestimo inner join LIVROS on EMPRESTIMOS.idLivro = LIVROS.idLivro 
    inner join CLIENTE on EMPRESTIMOS.idCliente = CLIENTE.idCliente inner join FUNCIONARIOS on EMPRESTIMOS.idFuncionario = FUNCIONARIOS.idFuncionario 
    inner join TIPOS_MULTA on MULTA.idTipoMulta = TIPOS_MULTA.idTipoMulta limit 30;
END ; $$
DELIMITER ;

DELIMITER $$
create trigger gerar_multa BEFORE UPDATE ON EMPRESTIMOS
FOR EACH ROW
	BEGIN
		DECLARE tipoMulta smallint default 0;
        DECLARE valor float default 0;
		IF new.statusEmprestimo <> old.statusEmprestimo THEN
			select idTipoMulta from TIPOS_MULTA where nomeTipo = new.statusEmprestimo into tipoMulta;
			IF tipoMulta = 3 THEN 
				select precoUnidade from LIVROS where idLivro = new.idLivro into valor;
			ELSEIF tipoMulta <> 0 THEN
				call cadastrar_multa(tipoMulta, old.idEmprestimo, old.idFuncionario, null, 'devendo', valor);
            END IF ;
        END IF ;
    END ; $$
DELIMITER ;





call cadastrar_cliente('Allan Carlos Correia', '12312312312', 'allan@gmail.com','1656161','regularizado','m');


call cadastrar_funcionario("Andressa","Gerente","f");
call cadastrar_usuario(1, 'Andressa', '123', 'admin');
call verifica_login('a','a');
 
 
call cadastrar_editora('Abril');
call cadastrar_editora('Companhia das Letras');    
call cadastrar_editora('Editora Rocco');    
call cadastrar_editora('Editora Arqueiro');    
call cadastrar_editora('Editora Intrínseca');    
call cadastrar_editora('Editora Sextante');    
call cadastrar_editora('Ediouro');    
call cadastrar_editora('Panda Books');    
call cadastrar_editora('FTD');    
call cadastrar_editora('Ubu');     
call cadastrar_editora('Alta Books');    
call cadastrar_editora('Aleph');    
call cadastrar_editora('Chiado Grupo Editorial');    
call cadastrar_editora('Edições Loyola');    
call cadastrar_editora('Editora Record');    
call cadastrar_editora('Draco');    
call cadastrar_editora('Gente');    
call cadastrar_editora('Martin Claret');    
call cadastrar_editora('Escala');    
call cadastrar_editora('Moderna');    
call cadastrar_editora('Melhoramentos');    
call cadastrar_editora('Grupo Pensamento');    
call cadastrar_editora('Panini');    
call cadastrar_editora('Boom! Studios');    
call cadastrar_editora('DC Comics / Vertigo');    
call cadastrar_editora('Dark Horse Comics');    
call cadastrar_editora('Fantagraphics');   
call cadastrar_editora('Image Comics / Top Cow Productions');     
call cadastrar_editora('Marvel Comics');     
call cadastrar_editora('Oni Press'); 
call cadastrar_editora('Tipografia Nacional'); 
call cadastrar_editora('Livraria Garnier');
call cadastrar_editora('Viking Press');
call cadastrar_editora('Doubleday');
call cadastrar_editora('Harvill Secker');




call cadastrar_autor('Machado de Assis');
call cadastrar_autor('José de Alencar');
call cadastrar_autor('Willian Shakespeare');
call cadastrar_autor('J. K. Rowling');
call cadastrar_autor('George Orwell');
call cadastrar_autor('Stephen King');
call cadastrar_autor('Aluísio Azevedo');
call cadastrar_autor('Eichiro Oda');
call cadastrar_autor('Masashi Kishimoto');
call cadastrar_autor('Akira Toriyama');
call cadastrar_autor('Yoshihiro Togashi');
call cadastrar_autor('Maurício de Souza');
call cadastrar_autor('Yusuke Murata');
call cadastrar_autor('Clarice Lispector');
call cadastrar_autor('Monteiro Lobato');
call cadastrar_autor('Cecília Meirelles');
call cadastrar_autor('Carlos Drummond de Andrade');
call cadastrar_autor('Paulo Coelho');
call cadastrar_autor('Lygia Fagundes Teles');
call cadastrar_autor('Guimarães Rosa');	




call cadastrar_categoria('Terror');
call cadastrar_categoria('Romance');
call cadastrar_categoria('Ficção');
call cadastrar_categoria('Aventura');
call cadastrar_categoria('Enciclopédia');
call cadastrar_categoria('Exatas');
call cadastrar_categoria('Humanas');
call cadastrar_categoria('Biológicas'); 
call cadastrar_categoria('Mangás');
call cadastrar_categoria('HQs');
call cadastrar_categoria('Poesia');   
    

desc livros;
select * from editora;
call cadastrar_livro(2,1,31,5,'Memórias Póstumas de Brás Cubas','',0);
call cadastrar_livro(2,1,32,7,'Dom Casmurro','',0);     
call cadastrar_livro(2,1,32,7,'Quincas Borba','',0);     
call cadastrar_livro(1,6,33,12,'It - A Coisa','',0);    
call cadastrar_livro(1,6,34,3,'O Iluminado','',0);      
call cadastrar_livro(1,6,34,3,'O Cemitério Maldito','',0);  
call cadastrar_livro(3,5,35,8,'1984','',0);   
call cadastrar_livro(3,5,35,8,'A Revolução dos Bichos','',0);  
call cadastrar_livro(11,17, 1, 10,'Poemas','',0);   
        
        
        
call carregar_categorias;
call carregar_autores;
call carregar_editoras;    
call carregar_livros(); 
insert into TIPOS_MULTA(nomeTipo, valor) values('atraso', 0.50), ('danificado', 1.50), ('perca', 0);

