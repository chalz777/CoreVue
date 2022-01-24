using SSRNMFSSN.Repository;
using Core.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SSRNMFSSN.Data.Models;
using SSRNMFSSN.Data.Models.DTO;
using SSRNMFSSN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSRNMFSSN.Domain
{
    public class ReportDomain
    {
        private ReportRepository _repo;

        public ReportDomain(ReportRepository repo)
        {
            _repo = repo;
        }

        public ICollection<SsrnmTrial> PacificNonAsw()
        {
            return _repo.GetPacificFleetNonASWOverview();
        }

        public ICollection<SsrnmTrial> PacificAsw()
        {
            return _repo.GetPacificFleetASWoverview();
        }

        public ICollection<SsrnmTrial> PacificCompleted()
        {
            return _repo.GetPacificFleetCompletedTrials();
        }

        public ICollection<SsrnmTrial> AtlanticCompleted()
        {
            return _repo.GetAtlanticFleetCompletedTrials();
        }

        public ICollection<SsrnmTrial> AtlanticCancelled()
        {
            return _repo.GetAtlanticFleetCancelledTrials();
        }

        public ICollection<SsrnmTrial> PacificCancelled()
        {
            return _repo.GetPacificFleetCancelledTrials();
        }

        public ICollection<SsrnmTrial> AtlanticPotential()
        {
            return _repo.GetAtlanticFleetPotentialTrials();
        }

        public ICollection<SsrnmTrial> PacificPotential()
        {
            return _repo.GetPacificFleetPotentialTrials();
        }

        public IEnumerable<Ship> GetHullDesginationList()
        {
            return _repo.GetHullDesginationList();
        }

        //public ICollection<SsrnmTrial> GetSsrnmTrials()
        //{
        //    var results = context.SsrnmTrial
        //        .Where(w => w.Ship.ShipStatus.ShipStatusId != 2)
        //        .OrderByDescending(o => o.TrialDate)
        //        .Take(15);

        //    return results.ToList();
        //}

        public ICollection<ControlNumber> GetControlNumbers()
        {
            return _repo.GetAll<ControlNumber>().ToList();
        }
        public ICollection<TrialStatusDescription> GetTrialStatusDescriptions()
        {
            return _repo.GetAll<TrialStatusDescription>().ToList();
        }
        public ICollection<Ship> GetShips()
        {
            return _repo.GetAll<Ship>().ToList();
        }
        public ICollection<TestSite> GetTestSites()
        {
            return _repo.GetAll<TestSite>().ToList();
        }
        public ICollection<TestSystem> GetTestSystems()
        {
            return _repo.GetAll<TestSystem>().ToList();
        }
        public ICollection<TrialStatus> GetTrialStatuses()
        {
            return _repo.GetAll<TrialStatus>().ToList();
        }
        public ICollection<TrialType> GetTrialTypes()
        {
            return _repo.GetAll<TrialType>().ToList();
        }
        public ICollection<User> GetUsers()
        {
            return _repo.GetAll<User>().ToList();
        }
    }
}
