<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZawodnicyAPI.aspx.cs" Inherits="P03AplikacjaZawodnicy.ZawodnicyAPI" %>

 <table class="table">
                    <thead class=" text-primary">
                      <th>
                        Imie i nazwisko
                      </th>
                      <th>
                        Kraj
                      </th>
                      <th>
                        Wzrost
                      </th>
                      <th >
                        Data ur
                      </th>
                      <th>Flaga</th>
                      <th>Trener</th>
                    </thead>
                    <tbody>
                      
                        <%
                            foreach (var z in Zawodnicy)
                            { %>

                                <tr>
                                    <td><a href="SzczegolyZawodnika.aspx?id=<%= z.Id_zawodnika %>"><%= z.ImieNazwisko %></a> </td>
                                    <td><%= z.Kraj %></td>
                                                                
                                    <td>
                                        <% if (z.Wzrost>180)
                                            {%>
                                            <b><%=z.Wzrost %></b>
                                       <%}
                                        else
                                         {%> 
                                            <%= z.Wzrost %>
                                          <% }%>    

                                    </td>
                                   

                                    <td><%= z.DataSformatowana %></td>

                                    <td><img style="width:30px;height:30px" src="Images/<%= z.Kraj.ToLower() %>.jpg" /></td>

                                    <td data-id="<%=z.Id_trenera %>" class="td_trener"><%= z.TrenerImieNazwisko %></td>

                                </tr>

                          <% }
                            %>
                       
                    </tbody>
                  </table>


