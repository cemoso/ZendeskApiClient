using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ZendeskApi.Client.Models;
using ZendeskApi.Client.Requests;
using ZendeskApi.Client.Responses;

namespace ZendeskApi.Client.Resources
{   
    /// <summary>
    /// <see cref="https://developer.zendesk.com/rest_api/docs/core/tickets"/>
    /// </summary>
    public interface ITicketsResource
    {
        #region GetAll Tickets
        Task<IPagination<Ticket>> GetAllAsync(
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IPagination<Ticket>> GetAllByOrganizationIdAsync(
            long organizationId,
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IPagination<Ticket>> GetAllByRequestedByIdAsync(
            long userId,
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IPagination<Ticket>> GetAllByCcdIdAsync(
            long userId,
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IPagination<Ticket>> GetAllByAssignedToIdAsync(
            long userId,
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));
        #endregion

        #region List Tickets
        [Obsolete("Use `GetAllAsync` instead.")]
        Task<IPagination<Ticket>> ListAsync(
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        [Obsolete("Use `GetAllByOrganizationIdAsync` instead.")]
        Task<IPagination<Ticket>> ListForOrganizationAsync(
            long organizationId, 
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        [Obsolete("Use `GetAllByRequestedByIdAsync` instead.")]
        Task<IPagination<Ticket>> ListRequestedByAsync(
            long userId, 
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        [Obsolete("Use `GetAllByCcdIdAsync` instead.")]
        Task<IPagination<Ticket>> ListCcdAsync(
            long userId, 
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));

        [Obsolete("Use `GetAllByAssignedToIdAsync` instead.")]
        Task<IPagination<Ticket>> ListAssignedToAsync(
            long userId, 
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));
        #endregion

        #region Show Tickets
        Task<TicketResponse> GetAsync(
            long ticketId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IPagination<Ticket>> GetAsync(
            long[] ticketIds, 
            PagerParameters pager = null,
            CancellationToken cancellationToken = default(CancellationToken));
        #endregion

        #region Create Tickets
        Task<TicketResponse> CreateAsync(
            TicketCreateRequest ticket,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<JobStatusResponse> CreateAsync(
            IEnumerable<TicketCreateRequest> tickets,
            CancellationToken cancellationToken = default(CancellationToken));
        #endregion

        #region Update Tickets
        Task<TicketResponse> UpdateAsync(
            TicketUpdateRequest ticket,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<JobStatusResponse> UpdateAsync(
            IEnumerable<TicketUpdateRequest> tickets,
            CancellationToken cancellationToken = default(CancellationToken));
        #endregion

        #region Mark Ticket as Spam and Suspend Requester
        Task<bool> MarkTicketAsSpamAndSuspendRequester(
            long ticketId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<JobStatusResponse> MarkTicketAsSpamAndSuspendRequester(
            long[] ticketIds,
            CancellationToken cancellationToken = default(CancellationToken));
        #endregion

        #region Delete Tickets
        Task DeleteAsync(
            long ticketId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task DeleteAsync(
            IEnumerable<long> ticketIds,
            CancellationToken cancellationToken = default(CancellationToken));
        #endregion
    }
}
