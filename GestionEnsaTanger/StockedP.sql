USE [ENSA_TANGER]
GO
/****** Object:  StoredProcedure [dbo].[Ajouter]    Script Date: 3/17/2023 9:47:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ajouter]
	@code_eleve varchar(255),
	@code_mat varchar(255),
	@note float(8)
AS
	INSERT INTO Notes(code_eleve,code_mat,note) VALUES (@code_eleve,@code_mat,@note)
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Modifier]    Script Date: 3/17/2023 9:47:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Modifier]
	@code_eleve varchar(255),
	@code_mat varchar(255),
	@note float(8)
AS
	UPDATE [dbo].[Notes]
   SET [note] = @note
 WHERE code_eleve = @code_eleve AND code_mat = @code_mat
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[Supprimer]    Script Date: 3/17/2023 9:47:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Supprimer]
	@code_eleve varchar(255),
	@code_mat varchar(255)
	
AS
	DELETE FROM [dbo].[Notes]
 WHERE code_eleve = @code_eleve AND code_mat = @code_mat
RETURN 0
GO
