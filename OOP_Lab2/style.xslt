<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"/>
  <xsl:template match="/">
    <html>
      <style>
        body {
          margin: 0;
        }

        #apps {
          font-family: Arial, Helvetica, sans-serif;
          border-collapse: collapse;
          width: 100%;
        }

        #apps td, #apps th {
          border: 1px solid #ddd;
          padding: 8px;
        }

        #apps tr:nth-child(even){
          background-color: #f2f2f2;
        }

        #apps tr:hover {
          background-color: #ddd;
        }

        #apps th {
          padding-top: 12px;
          padding-bottom: 12px;
          text-align: left;
          background-color: #04a4aa;
          color: white;
        }
      </style>
      <body>
        <table id="apps">
          <tr>
            <th>Name</th>
            <th>Id</th>
            <th>Developer</th>
            <th>Publisher</th>
            <th>User score</th>
            <th>Owners</th>
            <th>Price</th>
            <th>CCU</th>
          </tr>
          <xsl:for-each select="Apps/App">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="appid"/>
              </td>
              <td>
                <xsl:value-of select="developer"/>
              </td>
              <td>
                <xsl:value-of select="publisher"/>
              </td>
              <td>
                <xsl:value-of select="concat(round(positive div (positive + negative) * 100), '%')"/>
              </td>
              <td>
                <xsl:value-of select="owners"/>
              </td>
              <td>
                <xsl:value-of select="concat('$', price div 100)"/>
              </td>
              <td>
                <xsl:value-of select="ccu"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
