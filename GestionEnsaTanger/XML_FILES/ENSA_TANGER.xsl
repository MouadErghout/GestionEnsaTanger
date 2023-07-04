<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
   

    <xsl:template match="/">
		<html>
			<body>
				<h2>Eleve Supprimer</h2>
				<table border="1">
					<tr bgcolor="#9acd32">
						<th>Code Eleve</th>
						<th>Nom</th>
						<th>Prenom</th>
						<th>Filiere</th>
						<th>date Suppresion</th>
					</tr>
					<xsl:for-each select="ENSA_TANGER/Filiere/Niveau/Eleve">
						<tr>
							<td>
								<xsl:value-of select="@code"/>
							</td>
							<td>
								<xsl:value-of select="@nom"/>
							</td>
							<td>
								<xsl:value-of select="@prenom"/>
							</td>
							<td>
								<xsl:value-of select="@code_fil"/>
							</td>
							<td>
								<xsl:value-of select="DateSuppression/@date"/>
							</td>
							
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
